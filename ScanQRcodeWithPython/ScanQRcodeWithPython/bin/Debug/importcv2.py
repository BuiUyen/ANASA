import cv2
import numpy as np
from pyzbar.pyzbar import Decoded, decode
import keyboard
import time



def scan_qr_code():
    # Mở webcam
    cap = cv2.VideoCapture("http://192.168.1.18:4747/video")  # Sử dụng camera mặc định (ID = 0)
    
    last_scanned_time = 0  # Lưu thời gian quét gần nhất
    scan_interval = 1      # Khoảng thời gian (giây) giữa các lần quét
    

    try:
        while True:
            ret, frame = cap.read()
            if not ret:
                print("Không thể truy cập webcam.")
                break
            
            # Lấy thời gian hiện tại
            current_time = time.time()
            qr_codes = decode(frame)
            for qr in qr_codes:
                data = qr.data.decode('utf-8')  # Nội dung mã QR                
                    
                # Vẽ khung xung quanh mã QR
                points = qr.polygon
                if len(points) > 4:  # Xử lý mã QR bị méo
                    hull = cv2.convexHull(points)
                    points = hull
                points = [(p.x, p.y) for p in points]
                for i in range(len(points)):
                    start_point = points[i]
                    end_point = points[(i + 1) % len(points)]
                    cv2.line(frame, start_point, end_point, (0, 255, 0), 2)
                # Chỉ quét nếu đã qua 1 giây
                
                if current_time - last_scanned_time >= scan_interval:
                    last_scanned_time = current_time
                    print(data, flush=True)

            
            
                
            # Hiển thị video
            cv2.imshow("Quét mã QR", frame)
            
            # Nhấn 'q' để thoát
            if cv2.waitKey(1) & 0xFF == ord('q'):
                break
    finally:
        cap.release()
        cv2.destroyAllWindows()

# Chạy chương trình
scan_qr_code()