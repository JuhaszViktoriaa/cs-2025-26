# COUNT feladatok 

## Követelmények (kötelező keret)

- Hozz létre egy `ProductController` osztályt a `Controllers` mappába.
  
- A `ProductController` az `AppInMemoryContext` példányát használja az
  adateléréshez.
  
- Minden végpont **HTTP GET**, és **csak egy egész számot** ad vissza
  JSON-ban:
  
  ```json
  { "count": 12 }
  ```
  
### 1) Összes termék száma

**URL:** `GET /api/products/count/all`\
**Leírás:** Számold meg, hány termék található az adatbázisban
összesen.\
**Visszatérés:** `Ok(new { count })`

### 2) 1000 Ft alatti termékek száma

**URL:** `GET /api/products/count/price/less/1000`  
**Leírás:** Számold meg, hány termék ára **kisebb, mint 1000 Ft** (`Price < 1000`).  
**Visszatérés:** `Ok(new { count })`


### 3) 1000 Ft alatti aktív termékek száma

**URL:** `GET /api/products/count/price/active/1000`  
**Leírás:** Számold meg, hány *aktív * termék ára **kisebb, mint 1000 Ft**.  
**Visszatérés:** `Ok(new { count })`

### 4) Lejárati dátummal rendelkező termékek

**URL:** `GET /api/products/count/with-expiration`\
**Leírás:** Számold meg, hány terméknek van lejárati dátuma
(`ExpirationDate != null`).\
**Visszatérés:** `Ok(new { count })`

### 5) Vonalkód nélküli termékek

**URL:** `GET /api/products/count/no-barcode`\
**Leírás:** Számold meg, hány terméknek nincs vonalkódja.\
**Visszatérés:** `Ok(new { count })`

### 6) Készlettel rendelkező termékek

**URL:** `GET /api/products/count/in-stock`\
**Leírás:** Számold meg, hány terméknek a készlete nagyobb, mint 0.\
**Visszatérés:** `Ok(new { count })`

### 7) Nem adott kategóriájú termékek száma

**URL:** `GET /api/products/count/nocategory/{category}`\
**Leírás:** Számold meg, hány termék nem tartozik a megadott kategóriába.\
**Visszatérés:** `Ok(new { count })`

### 8) Adott ár feletti termékek száma

**URL:** `GET /api/products/count/price/greater/{minPrice}`\
**Leírás:** Számold meg, hány termék ára nagyobb a megadott értéknél.\
**Visszatérés:** `Ok(new { count })`

### 9) Meghatározott értékelésű termékek száma

**URL:** `GET /api/products/count/rating/{rating}`\
**Leírás:** Számold meg, hány termék értékelése pontosan a megadott szám.\
**Visszatérés:** `Ok(new { count })`

### 10) Adott napon létrehozott termékek száma

**URL:** `GET /api/products/count/created/{yyyy}-{MM}-{dd}`\
**Leírás:** Számold meg, hány termék `CreatedDate` értéke a megadott
napon van.\
**Visszatérés:** `Ok(new { count })`
