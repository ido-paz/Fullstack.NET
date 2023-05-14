# Mediator design pattern
 
 Enables to reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

 <img src="./1.png"/>

https://refactoring.guru/design-patterns/mediator

https://www.hackampus.com/book/230/chapter/1698/subject/5036

במערכת בה אתם עובדים נדרש לקיים תקשורת (הודעות) בין אובייקטים שונים, כאשר אסור להם "לדבר" זה עם זה ישירות. לשם כך מתעורר הצורך בקיום שכבה מקשרת שתחבר בין האובייקטים הללו. הדבר דומה למגדל פיקוח בשדה תעופה: כל המטוסים הממריאים ואלה שעומדים לנחות מתקשרים עם מגדל הפיקוח, והוא זה שנותן הוראות לטייסים כיצד לפעול, כאשר המסלול פנוי ויש אישור נחיתה וכו'...


דוגמא נוספת: חדר צ'אט באינטרנט. כל הודעה שנשלחת על ידי משתתף מגיעה לגורם מתווך והוא שולח את ההודעה לכל המשתתפים.