# GeuraLaundry
SISFO &amp; Antar Jemput Laundry (Kelompok 5 - IF Widyatama 2016)


## Database

### User
```
*_id
username
password

```

### Transaction
```
*_id
created_time
updated_time
finished_time
**package_id
**type_id
**user_id
**customer_id
status
weight
```

### Type
```
*_id
name
price
unit
```

### Package
```
*_id
name
estimate
```

### Customer
```
*_id
name
phone_number
address
```

