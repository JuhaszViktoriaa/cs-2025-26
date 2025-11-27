# COUNT feladatok --- Products (InMemory EF Core)

## Követelmények (kötelező keret)

-   Talál egy `ProductController` osztályt a `Controllers` mappába.

-   A `ProductController` az `AppInMemoryContext` példányát használja az
    adateléréshez.

    -   Ajánlott: konstruktor-injektálás (ASP.NET Core DI):`private readonly AppInMemoryContext _db;`
    
-   Minden végpont **HTTP GET**, és **csak egy egész számot** ad vissza
    JSON-ban:

    ``` json
    { "count": 12 }
    ```
-   A projekt tartalmaz egy tesztet is, a teszt segíthet a feladat megoldásának ellenörzésében.
  

------------------------------------------------------------------------

## Feladatok

### 1) Inaktív termékek száma

**URL:** `GET /api/products/count/inactive`\
**Leírás:** Számold meg, hány termék **inaktív** (`IsActive == false`).\
**Visszatérés:** `Ok(new { count })`

### 2) Lejárati dátum nélküli termékek

**URL:** `GET /api/products/count/no-expiration`\
**Leírás:** Számold meg, hány terméknek **nincs megadva** lejárati
dátuma (`ExpirationDate == null`).\
**Visszatérés:** `Ok(new { count })`

### 3) Vonalkóddal rendelkező termékek

**URL:** `GET /api/products/count/with-barcode`\
**Leírás:** Számold meg, hány terméknek van **nem üres** vonalkódja
(`Barcode`).\
**Visszatérés:** `Ok(new { count })`

### 4) Készlet nélküli termékek

**URL:** `GET /api/products/count/out-of-stock`\
**Leírás:** Számold meg, hány termék készlete **0**
(`QuantityInStock == 0`).\
**Visszatérés:** `Ok(new { count })`

### 5) Adott kategóriájú, adott ár alatti termékek

**URL:**
`GET /api/products/count/category/{category}/price/less/{maxPrice}`\
**Leírás:** Számold meg, hány termék tartozik `{category}` kategóriába
**ÉS** az ára `< {maxPrice}`.\
**Visszatérés:** `Ok(new { count, category, maxPrice })`

### 6) Névben részszóra illeszkedő termékek

**URL:** `GET /api/products/count/name/contains/{term}`\
**Leírás:** Számold meg, hány termék neve tartalmazza a megadott
`{term}` részszót (kis/nagybetűtől független).\
**Visszatérés:** `Ok(nnew { count, term })`

### 7) Meghatározott értékelési tartomány

**URL:** `GET /api/products/count/rating/between/{min}/{max}`\
**Leírás:** Számold meg, hány termék `Rating` mezője **nem null**, és
`min ≤ Rating ≤ max`.\
**Visszatérés:** `Ok(new { count, min, max })` (hibás paraméter esetén:
`BadRequest`)

### 8) Hamarosan lejáró termékek (nap alapú)

**URL:** `GET /api/products/count/expiring-in-days/{days}`\
**Leírás:** Számold meg, hány termék lejárati dátuma **a mai nap és a
mai nap + `{days}`** között van (zárt intervallum).\
**Visszatérés:** `Ok(new { count, days })` (negatív `days` esetén:
`BadRequest`)SWS

### 9) Súly szerinti tartomány + aktív státusz

**URL:** `GET /api/products/count/weight/between/{min}/{max}/active`\
**Leírás:** Számold meg, hány **aktív** termék rendelkezik **nem null**
`WeightKg` értékkel és `min ≤ WeightKg ≤ max`.\
**Visszatérés:** `Ok(new { count, min, max, active = true })` (hibás tartomány esetén:
`BadRequest`)

### 10) Dátum-napi pontosságú létrehozás

**URL:** `GET /api/products/count/created-on/{yyyy}-{MM}-{dd}`\
**Leírás:** Számold meg, hány termék `CreatedDate` értéke **ugyanarra a
napra esik**, mint a megadott dátum.\
**Visszatérés:** `Ok(new { count, date = targetDate.ToString("yyyy-MM-dd"))` (hibás dátumformátum esetén:
`BadRequest`)
