### Grupa8 - eDostava
----------------------

# Tema: Online dostava (eDostava)

-------------------------

![viber_image_2021-03-22_14-31-27](https://user-images.githubusercontent.com/73022116/111998118-ff632e80-8b1b-11eb-8c74-00a810c31ca0.png)

-------------------------

# Članovi:

-------------------------

* [Ina-Bedra Mujaković](https://github.com/inamujakovic)
* [Ema Kalmar](https://github.com/ekalmar1)
* [Rijad Zejnilović](https://github.com/Riqui10)

# Opis teme:
-------------------------

S obzirom da je čitav svijet zahvatila globalna pandemija uzrokovana virusom COVID-19 i da mnogi nisu u mogućnosti da odlaze u kupovinu, što zbog straha,
što zbog izolacije u kojoj se nalaze kao i niza drugih razloga, mi smo napravili web-aplikaciju u kojoj nudimo uslugu dostave prijeko potrebnih životnih potrepština.
Korisnici aplikacije imaju mogućnost odabira da li žele gotova jela iz restorana, lijekove iz apoteke ili namirnice iz trgovine.
Ako se odabere kategorija "Restoran" korisnik može birati restorane na osnovu vrste hrane, lokacije, a također može birati gotova jela iz svog omiljenog restorana.
U slučaju odabira "Prodavnica", korisnik može birati između namirnica, kućanskih potrepština i ostalih proizvoda iz ponude trgovine.
Što se tiče kategorije "Apoteka", nudimo dostavu svih vrsta lijekova koje nudi državna apoteka.
Naš tim prati iz kojeg dijela grada je narudžba izvršena, te vozač koji je najbliži datoj adresi obavlja dostavu kako bi što prije narudžba bila na vratima korisnika.
Korisnik ima mogućnost praćenja narudžbe od trenutka slanja narudžbe do trenutka pristizanja iste.
Nudimo mogućnost plaćanja putem kreditne kartice, PayPal-a ili prilikom preuzimanja narudžbe. 

# Funkcionalnosti:
--------------------------

## Korisnik
* Registracija korisnika: 
	- postojeći (mail i šifra),
	- novi korisnik (ime, prezime, šifra, adresa, mail, broj telefona),
	- gost (nema mogućnost izvršenja narudžbe)
* Pretraga:
	- Restoran:
		- lokacija
		- vrsta hrane (slatko/slano, junk food/healthy food)
		- omiljeni restoran
	- Prodavnica:
		- namirnice
		- kućanske potrepštine
		- ostalo
	- Apoteka:
		- lijekovi sa receptom (putem mobilnog uređaja se uslika recept i izvrši se upload slike recepta na web-stranicu) 
		- lijekovi bez recepta  
 
* Praćenje narudžbe:
	- na mobilni uređaj stiže poruka za koliko će narudžba biti dostavljena 
	- moguće je locirati narudžbu u svakom trenutku
* Plaćanje:
	- kreditna kartica
	- PayPal
	- plaćanje pri preuzimanju
* Feedback:
	- ocjena
	- komentar

## Gost
* Pregled ponude (bez mogućnosti narudžbe - READ-ONLY):
	- Restoran:
		- lokacija
		- vrsta hrane (slatko/slano, junk food/healthy food)
		- omiljeni restoran
	- Prodavnica:
		- namirnice
		- kućanske potrepštine
		- ostalo
	- Apoteka:
		- lijekovi sa receptom
		- lijekovi bez recepta

## Administrator
* Unos:
	- Restorani:
		- informacije o restoranu (adresa, radno vrijeme, ocjena restorana)
		- meni (opis jela, cijena)
		- akcijska ponuda (srijedom svi restorani imaju popust od 15% na kompletan meni)
	- Prodavnice:
		- informacije (adresa, radno vrijeme)
		- ponuda
	- Apoteke:
		- informacije (adresa, radno vrijeme)
* Brisanje korisnika
* Održavanje i ažuriranje sistema:
	- U slučaju da korisničkom računu niko nije pristupio duže od jedne godine, račun se briše
* Mogućnost pregleda svih registrovanih korisnika

# Detaljni opis:
--------------------------

Prilikom otvaranja web aplikacije, korisnik će biti u prilici da se prijavi. Ukoliko korisnik već ima otvoren račun na web aplikaciji, potrebno je da unese postojeći email i šifru. U slučaju da se prvi put registruje, potrebno je da unese pristupne podatke. Pristupni podatci podrazumijevaju ime i prezime, adresu, email, broj telefona te šifru korisničkog računa. Svaka dodatna informacija (kuća/stan, sprat, lift) je dobro došla. U slučaju da se korisnik ne želi prijaviti, omogućena mu je pretraga ponude aplikacije, bez mogućnosti izvršetka narudžbe. Ako korisnik ne pristupi računu duže od jedne godine, račun će se automatski izbrisati.

Nakon završetka prijave, korisnik je u mogućnosti da bira između restorana, prodavnice ili apoteke. U slučaju da se izabere restoran, pruža se mogućnost pretrage po lokaciji (u blizini) i/ili vrsti hrane (slatko/slano, junk food/healthy food). Ukoliko se odabere prodavnica, nudi se mogućnost izbora između namirnica (hrana i piće), kućanskih potrepština i ostalog. Ako korisnik izabere apoteku, bit će u mogućnosti da izabere kupovinu lijekova s receptom, odnosno bez recepta. Ako su mu potrebni lijekovi koji se prodaju uz recept, korisnik će biti u mogućnosti da svoj recept uslika i izvrši upload na web stranicu. 

Kada se narudžba prihvati, korisniku na mobilni uređaj stiže poruka za koliko će narudžba biti na njegovoj adresi. Pored toga, moguće je locirati narudžbu u svakom trenutku. Plaćanje se može obaviti na tri načina: kreditnom karticom, gotovinom ili PayPalom. Pri preuzimanju narudžbe, korisnik ima opciju da ostavi komentar i ocjenu. Korisnik – Gost ima mogućnost pregleda ponude.

Administrator web aplikacije je u mogućnosti da unosi nove, odnosno ažurira postojeće restorane, prodavnice i/ili apoteke. Prilikom unosa novih objekata, administrator unosi osnovne informacije. Administrator je u mogućnosti da vidi sve registrovane korisnike. U slučaju da korisničkom računu nitko nije pristupio duže od jedne godine, admin je u mogućnosti da isti obriše. Zaduženje administratora je da sistem održava i ažurira po potrebi.

# Akteri:
--------------------------

* Gost
* Korisnik
* Administrator
