### Grupa8 - eDostava
----------------------

# Tema: Online dostava (eDostava)

----------------------

Članovi:
----------------------

* [Ina Mujaković](https://github.com/inamujakovic)
* [Ema Kalmar](https://github.com/ekalmar1)
* [Rijad Zejnilović](https://github.com/Riqui10)

# Opis teme:
----------------------

S obzirom da je čitav svijet zahvatila globalna pandemija uzrokovana virusom COVID-19 i da mnogi nisu u mogućnosti da odlaze u kupovinu, što zbog straha,
što zbog izolacije u kojoj se nalaze kao i niza drugih razloga, mi smo napravili web-aplikaciju u kojoj nudimo uslugu dostave prijeko potrebnih životnih potrepština.
Korisnici aplikacije imaju mogućnost odabira da li žele gotova jela iz restorana, lijekove iz apoteke ili namirnice iz trgovine.
Ako se odabere kategorija "Restoran" korisnik može birati restorane na osnovu vrste hrane, lokacije, a također može birati gotova jela iz svog omiljenog restorana.
U slučaju odabira "Prodavnica", korisnik može birati između namirnica, kućanskih potrepština i ostalih proizvoda iz ponude trgovine.
Što se tiče kategorije "Apoteka", nudimo dostavu svih vrsta lijekova koje nudi državna apoteka.
Naš tim prati iz kojeg dijela grada je narudžba izvršena, te vozač koji je najbliži datoj adresi obavlja dostavu kako bi što prije narudžba bila na vratima korisnika.
Korisnik ima mogućnost praćenja narudžbe od trenutka slanja narudžbe do trenutka pristizanja iste.
Nudimo mogućnost plaćanja putem kreditne kartice, paypal-a ili prilikom preuzimanja narudžbe. 

# Funkcionalnosti:
----------------------

## Pogled - Korisnik:
* registracija korisnika 
	- postojeći (mail i šifra),
	- novi korisnik (ime, prezime, šifra, adresa, mail, broj telefona),
	- gost (nema mogućnost izvršenja narudžbe)
* pretraga
	- Restoran
		- lokacija
		- vrsta hrane (slatko/slano, junk food/healthy food)
		- omiljeni restoran
	- Prodavnica
		- namirnice
		- kućanske potrepštine
		- ostalo
	- Apoteka
		- lijekovi sa receptom
		- lijekovi bez recepta  
 
* praćenje narudžbe
* plaćanje
	- kreditna kartica
	- PayPal
	- plaćanje pri preuzimanju
* feedback
	- ocjena
	- komentar

## Pogled - Gost:
* pregled ponude (bez mogućnosti narudžbe - READ-ONLY)
	- Restoran
		- lokacija
		- vrsta hrane (slatko/slano, junk food/healthy food)
		- omiljeni restoran
	- Prodavnica
		- namirnice
		- kućanske potrepštine
		- ostalo
	- Apoteka
		- lijekovi sa receptom
		- lijekovi bez recepta

## Pogled - Administrator
* unos
	- restorani
		-informacije o restoranu (adresa, radno vrijeme, ocjena restorana)
		-meni (opis jela, cijena)
	- prodavnice
		- informacije (adresa, radno vrijeme)
		- ponuda
	- apoteke
		- informacije (adresa, radno vrijeme)
* brisanje korisnika
* održavanje i ažuriranje 
* mogućnost pregleda svih registrovanih korisnika
