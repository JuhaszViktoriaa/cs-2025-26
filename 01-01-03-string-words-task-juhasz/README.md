# Feladat: Sztringműveletek gyakorlása

## Célkitűzés
Készíts egy programot, amely a szövegek feldolgozásával kapcsolatos alapvető műveleteket gyakoroltatja: szavak listázása, kezdődés és végződés vizsgálata, és címformázás.

## Projekt felépítése

### 📄 Fájlok:
- **StringMuveletek.cs** – Ebben az osztályban lesznek a szövegfeldolgozási metódusok.
- **Program.cs** – Ez a program belépési pontja, ahol teszteled a metódusokat.

## Megoldandó részfeladatok (metódusok)

### 1. `SzavakListaja(string szoveg)`
- **Feladat:** Bontsd fel a teljes szöveget szavakra a szóköz karakter mentén.
- **Elvárt eredmény:** A szavakat tartalmazó `string[]` tömb.
- **Példa:** "alma a fa" => `["alma", "a", "fa"]`

### 2. `CimFormazas(string szoveg)`
- **Feladat:** A bemeneti szöveg minden szavát írd át úgy, hogy az első betű nagybetűs legyen, a többi pedig kisbetűs.
- **Elvárt eredmény:** "alma a fa alatt" => "Alma A Fa Alatt"

### 3. `SzavakKezdodikEvel(string[] szavak, string keresett)`
- **Feladat:** Add vissza azokat a szavakat, amelyek a megadott részlettel kezdődnek.
- **Elvárt eredmény:** ["alma", "asztal"] + "a" => `["alma", "asztal"]`

### 4. `SzavakVegzodikEvel(string[] szavak, string keresett)`
- **Feladat:** Add vissza azokat a szavakat, amelyek a megadott részlettel végződnek.
- **Elvárt eredmény:** ["körte", "fa", "alatt"] + "t" => `["alatt"]`

## Tesztelés (Program.cs)
- Használd a `Main` metódusban a `StringMuveletek` publikus metódusait.
- Teszteld mind a 4 metódust, legalább egy-egy bemenettel, és írd ki az eredményeket a konzolra.

## Kimeneti elvárás minta
🔹 Szavak listája:
- alma
- a
- fa

🔹 Címformázott szöveg:
Alma A Fa

🔹 Szavak, amelyek 'a'-val kezdődnek:
- alma
- a

🔹 Szavak, amelyek 't'-re végződnek:
- alatt

---

🔗 **Tipp**: Használj `StartsWith`, `EndsWith`, `char.ToUpper`, `Substring`, `Where`, `ToArray()` metódusokat!

Ha elkészültél, futtasd a programot, ellenőrizd az eredményeket, majd tedd be a projektedbe az osztályokat!

Jó munkát! 🚀
