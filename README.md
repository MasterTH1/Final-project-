Dice Roller Program
• ความเป็นมาของโปรแกรม
โปรแกรมนี้ถูกพัฒนาขึ้นเพื่อแก้ปัญหาของการทอยลูกเต๋าเพื่อให้ได้ผลลัพธ์ที่สุ่มได้ตามความเป็นจริง โดยผู้ใช้สามารถเลือกจำนวนลูกเต๋าที่ต้องการทอยได้.

• วัตถุประสงค์ของโปรแกรม
วัตถุประสงค์หลักของโปรแกรมคือการให้ผู้ใช้สามารถทอยลูกเต๋าตามความต้องการและบันทึกผลลัพธ์ลงในไฟล์ CSV เพื่อการอ้างอิงหรือการวิเคราะห์ข้อมูลต่อไป.

• โครงสร้างของโปรแกรม (Class Diagram) 

classDiagram

    class Dice {    
        -Random random    
        +Roll(): int       
    }
    class Program {    
        +Main(args: string[]): void
        +SaveToCSV(filePath: string, dices: Dice[]): void
    }
    Dice ..> Program


    flowchart LR
    A[Hard] -->|Text| B(Round)
    B --> C{Decision}
    C -->|One| D[Result 1]
    C -->|Two| E[Result 2]



• ชื่อของผู้พัฒนาโปรแกรม
นาย ทัตพงศ์ พงศ์สุวากร 663450039-7
    

