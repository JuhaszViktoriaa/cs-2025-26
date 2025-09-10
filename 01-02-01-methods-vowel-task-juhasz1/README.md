# 1.2.1 Szövegvizsgálat – Magánhangzók

## Feladat célja
A hallgató képes legyen karakterekkel és karakterláncokkal kapcsolatos vizsgálatokat végezni. A feladat során gyakorolhatók az elágazások, ciklusok és karakterekkel kapcsolatos metódusok, valamint megtanulható, hogyan lehet egy részfeladatot egy segédmetódusba kiszervezni.

---

## Előkészített állományok
A projekt tartalmazza a következő fájlokat:

- `Program.cs`: tartalmazza az automatikus teszthívásokat. Ezt nem kell módosítani.
- `Szovegmuveletek.cs`: tartalmazza a statikus osztályt a metódusvázakkal. Ezeket kell kitölteni.

---

## Feladatleírás
A `Szovegmuveletek` statikus osztályban valósítsa meg az alábbi két metódust.

### 1. `MaganhangzoE(char c)`
Döntse el, hogy a paraméterként kapott karakter magánhangzó-e.

#### Szempontok:
- Fogadja el a magyar és angol nyelv magánhangzóit kis- és nagybetűsen egyaránt:
  - Angol: a, e, i, o, u
  - Magyar: á, é, í, ó, ö, ő, ú, ü, ű

#### Javasolt megvalósítás:
- Elemi megoldásként `switch` szerkezet használata javasolt.

#### Futási példák:
- `MaganhangzoE('a')` → `true`
- `MaganhangzoE('x')` → `false`
- `MaganhangzoE('A')` → `true`
- `MaganhangzoE('Z')` → `false`
- `MaganhangzoE('ő')` → `true`

---

### 2. `TartalmazMaganhangzot(string szoveg)`
Vizsgálja meg, hogy a paraméterként kapott szöveg tartalmaz-e legalább egy magánhangzót.

#### Szempontok:
- A metódus hívja meg minden karakterre a `MaganhangzoE` metódust.
- Ha egy karakterre igaz, azonnal visszatér `true` értékkel.
- Ha egyre sem igaz, a visszatérési érték `false` legyen.

#### Futási példák:
- `TartalmazMaganhangzot("kutya")` → `true`
- `TartalmazMaganhangzot("krptn")` → `false`
- `TartalmazMaganhangzot("Asztal")` → `true`
- `TartalmazMaganhangzot("")` → `false`
- `TartalmazMaganhangzot("Xylvnn")` → `false`

---

## Általános elvárások
- Tiszta, átlátható kód
- A `MaganhangzoE` metódust építse be a `TartalmazMaganhangzot` metódusba, ne ismételje meg a logikát
- Teszteléshez futtassa a programot, a kimenet megmutatja, hogy helyesen működik-e a kód
