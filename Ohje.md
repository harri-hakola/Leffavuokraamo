# Leffavuokraamo
Leffavuokraamo:

Kun ohjelma käynnistetään, ohjelma lukee \bin\debug\vuokraelokuvat.txt tiedoston. 
Tekstitiedoston datasta luodaan VuokraElokuva oliot ja ne lisätään vuokraElokuvat-listaan. 

Sen jälkeen ohjelman päävalikko aukeaa. Ohjelmassa navigointi tapahtuu kirjainvalinnoilla: 

[k] Näytä kaikki elokuvat //Tulostaa kaikki elokuvat vuokraElokuvat listalta
[v] Vuokraa elokuva //Vuokrauksen jälkeen oliolle asetetaan palautuspäivä (nykyinen päivä + 3), ja (vuokrattavissa = false) 
[p] Palauta elokuva // Asettaa (vuokrattavissa=true)
[m] Päävalikko // Tulostaa päävalikon
[t] Tallenna elokuvat tiedostoon // Tallentaa kaikki elokuvat \bin\debug\backup.txt
[q] Lopetus // Sulkee ohjelman
