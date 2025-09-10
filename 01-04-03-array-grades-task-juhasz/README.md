# 1.4.3 Tanulmányi adatok feldolgozása – Egydimenziós tömbök

A feladatban 20 tanuló neve és jegye adott, két tömbben tárolva. A diákok dönthetnek: megoldják csak a számadatokkal, vagy bővítik a feladatot a nevek kiíratásával is. A feladatokat elemi programozási eszközökkel kell megoldani (ciklusok, elágazások, Length, Contains).

## Kezdeti adatok
```
names = { Anna, Bence, Csilla, Dávid, Erika, Ferenc, Gábor, Hanna, István, Judit,
          Kata, László, Mária, Norbert, Orsolya, Péter, Rita, Sándor, Tamás, Zsófia }
grades = { 5, 3, 2, 4, 1, 2, 5, 4, 3, 2, 5, 1, 4, 3, 2, 5, 5, 1, 3, 4 }
```

## Feladatok és elvárt kimenetek
### 1. Jegyek kiíratása
Elvárt kimenet: 5 3 2 4 1 2 5 4 3 2 5 1 4 3 2 5 5 1 3 4
... vagy nevekkel soronként.

### 2. Jegyek száma
Elvárt kimenet: Jegyek száma: 20

### 3. Első és utolsó jegy
Elvárt kimenet: Első jegy: 5, Utolsó jegy: 4
... vagy nevekkel: Anna – 5, Zsófia – 4

### 5. Jegyek átlaga
Elvárt kimenet: Átlag: 3.20

### 6. Legjobb jegy
Elvárt kimenet: Legjobb jegy: 5
Névvel: Anna – 5, Gábor – 5, Kata – 5, Péter – 5, Rita – 5

### 7. Legrosszabb jegy
Elvárt kimenet: Legrosszabb jegy: 1
Névvel: Erika – 1, László – 1, Sándor – 1

### 8. Hány ötös volt?
Összesen: 5 (Anna, Gábor, Kata, Péter, Rita)

### 9. Bukások száma
Összesen: 3 (Erika, László, Sándor)

### 10. Jegy keresése (pl. 4)
Dávid – 4, Hanna – 4, Mária – 4, Zsófia – 4

### 11. Jegyek megfordítása
Elvárt: fordított sorrend, nevekkel is.

### 12. Legjobb és legrosszabb helye
Elvárt: Legjobb: Anna – 5 (pozíció 1), Legrosszabb: Erika – 1 (pozíció 5)

### 13. Van-e javulás?
Elvárt kimenet: Volt javulás? Igen

### 14. Átlag feletti jegyek
Összesen 9 fő, pl. Anna – 5, Dávid – 4, … Zsófia – 4

### 15. Rendezés növekvő sorrendbe
Elvárt sorrend: Erika – 1, László – 1, … Rita – 5

