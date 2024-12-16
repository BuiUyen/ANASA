const express = require('express');
const path = require('path');

const app = express();
const port = 3000;

// Cung cấp file tĩnh trong thư mục "public"
app.use(express.static(path.join(__dirname, 'public')));

// Điểm truy cập chính
app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, 'public', 'index.html'));
});

// Khởi động server
app.listen(port, () => {
    console.log(`Server chạy tại http://localhost:${port}`);
});
