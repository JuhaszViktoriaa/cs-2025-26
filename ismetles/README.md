# 1.2.1 – Esemény végének kiszámítása (C#)
## Feladat leírása
Egy felhasználó egy programot szeretne, amely segít kiszámítani, hogy egy esemény mikor ér véget, ha megadja annak kezdési időpontját (dátum, óra, perc) és időtartamát (óra, perc).
A célja az, hogy például naptári események időzítését, események ütközését vagy befejezését könnyen ellenőrizni tudja.
A program belépési pontját a Program.cs fájl tartalmazza, amely beolvassa vagy előállítja a bemeneti adatokat, majd meghívja az EventCalculator.CalculateEnd metódust.

## A `CalculateEnd` metódus feladata
`public static (DateOnly, int, int) CalculateEnd(DateOnly startDate, int startHour, int startMinute, int durationHours, int durationMinutes)`    
A CalculateEnd metódus célja, hogy egy esemény kezdő időpontjából és időtartamából meghatározza, mikor fejeződik be az esemény. A befejezés időpontját a metódus DateOnly, óra és perc formájában adja vissza egy tuple-ben.

## Paraméterek
 - startDate – Az esemény kezdő dátuma (DateOnly típus).
 - startHour – Az esemény kezdő órája (int, 0–23).
 - startMinute – Az esemény kezdő perce (int, 0–59).
 - durationHours – Az esemény hossza órában (int, nem lehet negatív).
 - durationMinutes – Az esemény hossza percben (int, nem lehet negatív).

## Elvárt működés (példák)

| Kezdés dátum | Kezdés idő | Hossz         | Befejezés dátum | Befejezés idő |
| ------------ | ---------- | ------------- | --------------- | ------------- |
| 2025.06.23   | 22:45      | 2 óra 30 perc | 2025.06.24      | 01:15         |
| 2025.06.10   | 10:15      | 1 óra 50 perc | 2025.06.10      | 12:05         |
| 2025.06.30   | 23:30      | 0 óra 45 perc | 2025.07.01      | 00:15         |
| 2025.12.31   | 20:00      | 6 óra 0 perc  | 2026.01.01      | 02:00         |

## Hibakezelés
A metódusnak ellenőriznie kell, hogy a következő feltételek teljesülnek:
Negatív időtartam:
- Ha a durationHours kisebb, mint 0, kivételt kell dobni:
`throw new ArgumentException("Az esemény hossza órában nem lehet negatív!", nameof(durationHours));`
- Ha a durationMinutes kisebb, mint 0, szintén kivételt kell dobni:
`throw new ArgumentException("Az esemény hossza percben nem lehet negatív!", nameof(durationMinutes));`   
⚠️ A kivételeket try-catch blok lekezelni a Program.cs fájlban.

## Feladat
- Készítsd el az EventCalculator.CalculateEnd metódus teljes implementációját a fentiek szerint!
- Gondoskodj róla, hogy a metódus minden bemeneti esetre megfelelő eredményt adjon vissza!
- Az elkészült metódus után készíts el egy XML dokumentációs kommentblokkot a CalculateEnd metódus fölé, amely leírja a metódus célját, paramétereit és visszatérési értékét! (/// segítségével)
