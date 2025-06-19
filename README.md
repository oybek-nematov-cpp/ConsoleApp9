# 👩‍🏫👨‍🎓 C# Dasturi: Student va Teacher Klasslari Bilan Obyektga Yo'naltirilgan Dasturlash

Ushbu loyiha `C#` dasturlash tilida yozilgan bo‘lib, unda **obyektga yo‘naltirilgan dasturlash (OOP)** prinsiplari asosida `Person`, `Student` va `Teacher` klasslari ishlatilgan.

## 📚 Vazifa mazmuni

Foydalanuvchidan uch kishining ismi so‘raladi:
- 2 ta **Student (talaba)**
- 1 ta **Teacher (o‘qituvchi)**

So‘ngra, har bir sinfga mos metodlar ishga tushiriladi:
- `Teacher` → `Explain()`
- `Student` → `Study()`

## 🧱 Strukturasi

### 1. `Person` klassi:
- `Name` — foydalanuvchi ismi (`string` tipida)
- Konstruktor — ismini parametr sifatida oladi
- `ToString()` metodi qayta aniqlangan (`override`)

### 2. `Student` klassi (Person'dan meros olgan):
- `Study()` — "The student is studying" matnini konsolga chiqaradi
- Konstruktor — bazaviy klass konstruktorini chaqiradi

### 3. `Teacher` klassi (Person'dan meros olgan):
- `Explain()` — "The teacher is explaining" matnini konsolga chiqaradi
- Konstruktor — bazaviy klass konstruktorini chaqiradi

### 4. `Program` klassidagi `Main` metodi:
- Foydalanuvchidan 3 ta ism qabul qilinadi
- Har biri `Person` tipidagi massivga saqlanadi
- So‘ng `Explain()` va `Study()` metodlari chaqiriladi

## 💻 Dastur ishga tushganda

```text
1-talabaning ismini kiriting: Ali
2-talabaning ismini kiriting: Vali
O'qituvchining ismini kiriting: Karim

The teacher is explaining
The student is studying
The student is studying
```
[t.me/Oybek_FN](https.//t.me/Oybek_FN)

[Rasm bor](screen.jpg)
