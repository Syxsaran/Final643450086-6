# Final643450086-6
ส่วนลดคือ ABC
```mermaid
classDiagram
  direction LR
  class form1{
  sweet()
  drink()
  logout()
  }
  class sweet{
  -name
  -amount
  -price
  -code
  open()
  save()
  back()
  }
  class drink{
  -name
  -amount
  -price
  -code
  open()
  save()
  back()
  }
  class savedrink{
  -location file
  save file()
  }
  class opendrink{
  -location file
  open file()
  }
  class opensweet{
  -location file
  open file()
  }
  class savesweet{
  -location file
  open file()
  }
  savedrink --|> drink
  opendrink --|> drink
  
  savesweet --|> sweet
  opensweet --|> sweet
  
  sweet --|> form1
  drink --|>form1
```
