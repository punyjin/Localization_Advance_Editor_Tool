# ตัวอย่างโปรแกรม เข้ารหัส และ ถอดรหัสไฟล์ .txt / .csv เพื่อนำไปใช้ต่อในด้านอื่นๆ ด้วยการเข้ารหัสด้วย AES (Advanced Encryption Standard)

## เกี่ยวกับโปรเจคนี้
โปรเจคนี้เป็นการจำลองโปรแกรม เข้ารหัสและถอดรหัสไฟล์ .csv มาแสดงบนแบบตาราง และสามารถ Export ออกเป็น .txt / .csv ได้
โดยจุดประสงค์ของโปรเจคนี้คือ การเข้ารหัสไฟล์ String หรือ ข้อมูลไฟล์ที่สำคัญๆ เป็นตัวอย่างการเข้ารหัสแบบพื้นฐาน เพื่อนำไปใช้กับโปรแกรมอื่นๆ

## ฟีเจอร์ในโปรเจคนี้ 
- **AES Encrypt**: การเข้ารหัสแบบ AES และ การถอดรหัสแบบ AES โดยกำหนดคีย์ผ่าน โปรแกรม GenKey หรือ จะสร้างขึ้นเองก็ได้
- **Table Editor**: โปรแกรมนี้จะนำเข้าไฟล์ .csv มาและแสดงผลในรูปแบบของ ตาราง โดยมี Header Colum และ Sub Colum ตามที่มี และแสดงผลต่อบรรทัดเพื่อให้ง่ายต่อการจัดการ
- **Menu Insert Tool**: การสร้าง CMS เพื่อให้ง่ายต่อการใช้งานและการจัดการช่องข้อความบรรทัดนั้นๆ เช่น (HEX Color Insert) เป็นต้น

## สื่งที่ต้องมี
ตรวจสอบอุปกรณ์ของท่านก่อนว่าได้ทำตามข้อกำหนดต่อไปนี้หรือไม่:
- ติดตั้ง Vistual Studio เวอร์ชั่นใดก็ได้ บนเครื่อง
  
## การติดตั้ง
1. ติดตั้ง Visual Studio IDE :
   
   **[VS2022](https://visualstudio.microsoft.com/vs/)**  
2. ดาวน์โหลดและแตกไฟล์ หรือจะโคลนก็ได้:
   ```bash
   git clone https://github.com/punyjin/Localization_Advance_Editor_Tool.git
   
3. ตั้งค่า Key & KeyIV:
   ```bash
   private static readonly string UeHex = "ใส่ Key";
   private static readonly string ivHex = "ใส่ KeyIV";
   
