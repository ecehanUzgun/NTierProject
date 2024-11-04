# NTier Ecommerce Project (Katmanlı Eticaret Projesi)


## MODEL
Bu katman DAL katmanına referans verecek olan katmandır. Bünyesinde veritabanında tablo haline gelecek olan varlıkları (entity) barındırır. Bu sepepten dolayı her bir entity SRP (Single responsibility) olacak şekilde tanımlanmıştır.
	- Abstracts: Entity'lere öncülük edecek arayüzü (interface) barındırır. Bu interface'in temel amacı ise LSP (Liskov's Substitution Principle) yerine getirmektedir.		
	- Concretes: Interface ve Abstract class'lardan türetilen somut nesneleri barındırır.
	- Entities: veritabanında tablo haline gelecek olan nesneleri barındırır.
	--Enums: Entitylerde kullanılan sabit (enum) değerleri barındırır.
			

## DAL (Data Access Layer)
	
	--Configurations (Kolon özelleştirmeleri)

	--Context
		--OnModelCreating


## BLL (Business Logic Layer)
 
## UI (User Interface)

	### ConsoleUI
	### MVC (UI)
		--wwwroot
			--images
				--productImages
				--UserImages
	https://localhost:7656/images/product/tshirt.jpg
	### API