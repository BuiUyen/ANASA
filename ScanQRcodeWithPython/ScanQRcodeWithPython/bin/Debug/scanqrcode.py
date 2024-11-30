import cv2
import numpy as np
from pyzbar.pyzbar import Decoded, decode
import keyboard
import time

last_scanned_time = 0  # Lưu thời gian quét gần nhất
scan_interval = 1      # Khoảng thời gian (giây) giữa các lần quét


with open('file.txt', 'r', encoding='utf-8') as file:  
    content = file.read()  # Đọc toàn bộ nội dung file
    print(content)  # In ra nội dung file


cap = cv2.VideoCapture(0)

while True:
    # Lấy thời gian hiện tại
    current_time = time.time()

    if current_time - last_scanned_time >= scan_interval:
        last_scanned_time = current_time

        print(current_time - last_scanned_time)
        
        success, img = cap.read()
        for barcode in decode(img):
            # print(barcode.data)
            myData = barcode.data.decode('utf-8')
            print(myData, flush=True)

            pts = np.array([barcode.polygon], np.int32)
            pts = pts.reshape((-1, 1, 2))
            cv2.polylines(img, [pts], True, (255,0,255), 5)
            pts2 = barcode.rect
            cv2.putText(img, myData, (pts2[0], pts2[1]), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (255, 165,0), 2)    






    
         
    cv2.imshow('Scan QR Code - BUI HUU UYEN', img)
    cv2.waitKey(1)
    if keyboard.is_pressed('q'): 
       break  
   
