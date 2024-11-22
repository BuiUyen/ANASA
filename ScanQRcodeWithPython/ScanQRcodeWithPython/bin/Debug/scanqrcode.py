import cv2
import numpy as np
from pyzbar.pyzbar import Decoded, decode
import keyboard
cap = cv2.VideoCapture("rtsp://uyen:@Uyen23071998@192.168.1.7:554/cam/realmonitor?channel=4&subtype=0&unicast=true&proto=Onvif")
cap.set(3, 640)
cap.set(4, 480)
while True:
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
         
    cv2.imshow('Scan QR Code - BIO HUU UYEN', img)
    cv2.waitKey(1)
    if keyboard.is_pressed('q'): 
       break  

   
