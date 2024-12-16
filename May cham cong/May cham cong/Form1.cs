using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using zkemkeeper; // SDK từ ZKTeco
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttendanceManager
{
    

    public partial class Form1 : Form
    {
        public class User
        {
            public int UserID { get; set; }
            public String UserName { get; set; }
        }

        private CZKEMClass axCZKEM1 = new CZKEMClass(); // SDK giao tiếp
        private bool isConnected = false;
        private int machineNumber = 1;
        string ipAddress;
        int port;
        
        List<int> mListUserID = new List<int>();
        List<User> mListUser= new List<User>();


        public Form1()
        {
            InitializeComponent();
            txtIPAddress.Text = "192.168.1.201";
            txtPort.Text = "4370";

            ipAddress = txtIPAddress.Text;
            port = int.Parse(txtPort.Text);

            comboBoxPrivilege.Items.Add("Người dùng");
            comboBoxPrivilege.Items.Add("Quản trị viên");

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            isConnected = axCZKEM1.Connect_Net(ipAddress, port);
            if (isConnected)
            {
                MessageBox.Show("Kết nối thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại. Kiểm tra IP hoặc cổng.", "Lỗi");
            }
        }

        private void btnGetAttendance_Click(object sender, EventArgs e)
        {            
            if (!isConnected)
            {
                MessageBox.Show("Chưa kết nối máy chấm công.", "Lỗi");
                return;
            }

            GetAllUser();

            // Xác định số lượng bản ghi trong máy
            int logCount = 0;
            if (!axCZKEM1.GetDeviceStatus(machineNumber, 6, ref logCount))
            {
                MessageBox.Show("Không thể lấy số lượng log.");
                return;
            }
            MessageBox.Show($"Số lượng log trong thiết bị: {logCount}");

            // Khởi tạo DataTable để lưu dữ liệu
            DataTable dtLogs = new DataTable();
            dtLogs.Columns.Add("UserID", typeof(string));
            dtLogs.Columns.Add("UserName", typeof(string));
            dtLogs.Columns.Add("VerifyMode", typeof(string));
            dtLogs.Columns.Add("InOutMode", typeof(string));
            dtLogs.Columns.Add("DateTime", typeof(string));

            // Đọc dữ liệu chấm công
            string enrollNumber; // Mã số đăng ký (ID của người dùng)
            int verifyMode, inOutMode, year, month, day, hour, minute, second;
            int dwWorkCode = 0;

            axCZKEM1.EnableDevice(machineNumber, false); // Tắt thiết bị để đọc dữ liệu
            if (axCZKEM1.ReadGeneralLogData(machineNumber)) // Đọc dữ liệu log
            {
                while (axCZKEM1.SSR_GetGeneralLogData(machineNumber, out enrollNumber, out verifyMode,
                    out inOutMode, out year, out month, out day, out hour, out minute, out second, ref dwWorkCode))
                {
                    String UserName = mListUser.FirstOrDefault(x => x.UserID.ToString() == enrollNumber).UserName.ToString();


                    // Thêm bản ghi vào DataTable
                    dtLogs.Rows.Add(
                        enrollNumber,
                        UserName,
                        GetVerifyMode(verifyMode),
                        GetInOutMode(inOutMode),
                        new DateTime(year, month, day, hour, minute, second).ToString("yyyy-MM-dd HH:mm:ss")
                    );
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu chấm công hoặc lỗi đọc dữ liệu.");
            }
            axCZKEM1.EnableDevice(machineNumber, true); // Bật lại thiết bị            

            // Hiển thị dữ liệu lên DataGridView
            dataGridViewLogs.DataSource = dtLogs;
        }

        private void GetAllUser()
        {
            string enrollNumber, name, password;
            int privilege;
            bool enabled;


            axCZKEM1.EnableDevice(machineNumber, false); // Tắt thiết bị trước khi lấy dữ liệu

            // Lấy danh sách người dùng
            if (axCZKEM1.ReadAllUserID(machineNumber)) // Đọc danh sách ID người dùng
            {
                while (axCZKEM1.SSR_GetAllUserInfo(machineNumber, out enrollNumber, out name, out password, out privilege, out enabled))
                {
                    User _user = new User();
                    _user.UserID = Int32.Parse(enrollNumber);
                    _user.UserName = name;
                    mListUser.Add(_user);
                }

            }
            else
            {
                MessageBox.Show("Không có người dùng nào trên thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            axCZKEM1.EnableDevice(machineNumber, true); // Bật lại thiết bị

        }

        // Chuyển đổi mã xác minh thành chuỗi mô tả
        private string GetVerifyMode(int mode)
        {
            string output;
            switch (mode)
            {
                case 1:
                    output = "Vân tay";
                    break;
                case 2:
                    output = "Thẻ từ";
                    break;
                case 0:
                    output = "Mật khẩu";
                    break;
                default:
                    output = "Không xác định";
                    break;
            }
            return output;
        }

        // Chuyển đổi mã InOut thành chuỗi mô tả
        private string GetInOutMode(int mode)
        {
            string output;
            switch (mode)
            {
                case 0:
                    output = "Vào";
                    break;
                case 1:
                    output = "Ra";
                    break;
                default:
                    output = "Không xác định";
                    break;
            }
            return output;
        }


    private void btnClearAttendance_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Chưa kết nối máy chấm công.", "Lỗi");
                return;
            }

            if (axCZKEM1.ClearGLog(machineNumber))
            {
                MessageBox.Show("Xóa dữ liệu chấm công thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không thể xóa dữ liệu.", "Lỗi");
            }
        }

        private void btnClearAllData_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Chưa kết nối máy chấm công.", "Lỗi");
                return;
            }

            
        }

        DataTable dtUsers;

        private void buttonGetUsers_Click(object sender, EventArgs e)
        {
            // Khởi tạo DataTable để lưu thông tin người dùng
            dtUsers = new DataTable();
            dtUsers.Columns.Add("UserID", typeof(string));
            dtUsers.Columns.Add("Name", typeof(string));
            dtUsers.Columns.Add("Password", typeof(string));
            dtUsers.Columns.Add("Privilege", typeof(string));
            dtUsers.Columns.Add("Enabled", typeof(string));

            string enrollNumber, name, password;
            int privilege;
            bool enabled;

            axCZKEM1.EnableDevice(machineNumber, false); // Tắt thiết bị trước khi lấy dữ liệu

            // Lấy danh sách người dùng
            if (axCZKEM1.ReadAllUserID(machineNumber)) // Đọc danh sách ID người dùng
            {
                while (axCZKEM1.SSR_GetAllUserInfo(machineNumber, out enrollNumber, out name, out password, out privilege, out enabled))
                {
                    // Thêm thông tin người dùng vào DataTable
                    dtUsers.Rows.Add(
                        enrollNumber,
                        name,
                        password,
                        privilege == 0 ? "Người dùng" : "Quản trị viên",
                        enabled ? "Hoạt động" : "Vô hiệu hóa"
                    );

                    mListUserID.Add(Int32.Parse(enrollNumber));
                }
            }
            else
            {
                MessageBox.Show("Không có người dùng nào trên thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            axCZKEM1.EnableDevice(machineNumber, true); // Bật lại thiết bị            

            // Hiển thị thông tin người dùng lên DataGridView
            dataGridViewNguoiDung.DataSource = dtUsers;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                isConnected = axCZKEM1.Connect_Net(ipAddress, port);

                if (!isConnected)
                {
                    MessageBox.Show("Không thể kết nối đến thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string userID = txtUserID.Text.ToString().Trim(); // ID của người dùng
                string userName = txtNameUser.Text.ToString(); // Tên người dùng
                string password = txtPassUser.Text.ToString(); // Mật khẩu (bỏ trống nếu không cần)

                int privilege;
                if (comboBoxPrivilege.Text == "Quản trị viên")
                {
                    privilege = 1; // 0 = Người dùng thường, 1 = Quản trị viên
                }
                else
                {
                    privilege = 0;
                }                
                bool enabled = true; // Trạng thái hoạt động

                axCZKEM1.EnableDevice(machineNumber, false); // Tắt thiết bị trước khi ghi dữ liệu

                bool isSaved = axCZKEM1.SSR_SetUserInfo(machineNumber, userID, userName, password, privilege, enabled);

                if (isSaved)
                {
                    MessageBox.Show("Dữ liệu người dùng đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lưu thông tin người dùng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show($"Lỗi khi lưu dữ liệu người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            axCZKEM1.EnableDevice(machineNumber, true); // Bật lại thiết bị
            axCZKEM1.Connect_Net(ipAddress, port);
            buttonGetUsers_Click(sender, e);
        }

        private void dataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNguoiDung.Rows[e.RowIndex];

            txtUserID.Text = Convert.ToString(row.Cells["UserID"].Value);
            txtNameUser.Text = Convert.ToString(row.Cells["Name"].Value);
            txtPassUser.Text = Convert.ToString(row.Cells["Password"].Value);
            comboBoxPrivilege.Text = Convert.ToString(row.Cells["Privilege"].Value);
            comboBoxEnabled.Text = Convert.ToString(row.Cells["Enabled"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipAddress = "192.168.1.201"; // Địa chỉ IP thiết bị
            int port = 4370; // Cổng mặc định
            bool isConnected = axCZKEM1.Connect_Net(ipAddress, port);

            if (!isConnected)
            {
                MessageBox.Show("Không thể kết nối đến thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thông tin người dùng cần lưu
            string userID = "4"; // ID người dùng
            string userName = "Nguyen Van A"; // Tên người dùng
            string password = ""; // Mật khẩu (nếu không cần thì để trống)
            int privilege = 0; // 0 = Người dùng thường, 1 = Quản trị viên
            bool enabled = true; // Trạng thái hoạt động
             
            // Kiểm tra người dùng đã tồn tại chưa
            bool userExists = axCZKEM1.SSR_GetUserInfo(machineNumber, userID, out _, out _, out _, out _);

            axCZKEM1.EnableDevice(machineNumber, false); // Tắt thiết bị trước khi xử lý

            if (userExists)
            {
                // Cập nhật thông tin người dùng
                bool isUpdated = axCZKEM1.SSR_SetUserInfo(machineNumber, userID, userName, password, privilege, enabled);
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Thêm mới người dùng
                bool isSaved = axCZKEM1.SSR_SetUserInfo(machineNumber, userID, userName, password, privilege, enabled);
                if (isSaved)
                {
                    MessageBox.Show("Thêm người dùng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm người dùng mới thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            axCZKEM1.EnableDevice(machineNumber, true); // Bật lại thiết bị            
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int userID = Int32.Parse(txtUserID.Text.ToString().Trim());
                if(mListUserID.Contains(userID))
                {
                    btnSaveUser.Text = "Thay đổi thông tin";
                }    
                else 
                {
                    btnSaveUser.Text = "Thêm người dùng mới";
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thông tin người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
