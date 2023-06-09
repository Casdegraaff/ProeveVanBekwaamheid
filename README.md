# ProeveVanBekwaamheid

## Gemeente Amsterdam cybersecurity voorlichtings training
Een op aanvraag gemaakte cybersecurity training voor het interne team bij de gemeente van Amsterdam.

Het idee achter onze training is om de werkers meer inzicht te geven over hoe belangrijk goede cybersecurity is.
Wij hebben hiervoor 2 verschillende soorten games gemaakt: 

* Een training om je kennis over cybersecurity termen te testen door middel van een quiz
* Een phishing/scam training waarin je over meerdere emails moet zeggen of ze echt zijn of dat het complete fraude is.

## Team:
1. Ruben Dudink (**Scrum Master**)
2. Cas de Graaff (**Lead dev & notulist**)
3. Quinn Croese 
4. Lynn Hiep (**Scrum Master**)
5. Miles Schalkwijk (**Lead artist**)
6. Sanne Kaat (**Product owner**)
7. Mila Verwer

## Software
Engine:
- Unity Version 2021.3.16f1
- Visual Studio 2019

overige software:
- Github Desktop
- Github (website)
- Trello

## Scrum
- Trello: https://trello.com/b/a9ObwGlP/proeve-van-bekwaamheid
- Daily standup: https://docs.google.com/document/d/1Fxdfdl2-rihQCaTwSPO_YCbfMLdc1HjXsyDNyNCSXDw/edit?usp=sharing

## Sprints
- Sprint 1: 20/03/2023 - 07/04/2023
- Sprint 2: 10/04/2023 - 26/04/2023
- Sprint 3: 8/05/2023  - 26/05/2023

## Geproduceerde game onderdelen

### Cas  
 Quiz game:  

[Willekeurige vraag generator en eind score](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/QuizGame/QuizManager.cs)   

### Ruben  
 Algemeen:  

[Dialogue systeem](https://github.com/Casdegraaff/ProeveVanBekwaamheid/tree/Development/Assets/Scripts/DialogueScripts)    

 Email game:  

[Show email knoppen](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/EmailGame/EmailButtons/EmailSpawner.cs)  

[true false knoppen](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/EmailGame/EmailButtons/ButtonChoice.cs)



### Quinn  
 Menu:  

[Klikbaar monitor systeem](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/Animation/start_game.cs)

[Main menu en options menu](https://github.com/Casdegraaff/ProeveVanBekwaamheid/tree/Development/Assets/Scripts/MainMenu)

[Inlog scherm](https://github.com/Casdegraaff/ProeveVanBekwaamheid/tree/Development/Assets/Scripts/SignIn)

Email game:    

[Nep of echt email knoppen & game finish](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/EmailGame/EmailButtons/ButtonChoice.cs) 

## Quiz game door Cas

### Visual sheet score:

Hier laat ik zien hoe het score systeem werkt door middel van een visual sheet.

De code van deze feature kan je [hier](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/QuizGame/QuizManager.cs) vinden.

![QuizScoreSheet](https://github.com/Casdegraaff/ProeveVanBekwaamheid/assets/54799365/d786e441-74a6-45ad-9749-3ff5930a22cd)

### Visual sheet vragen randomizer:

Hier laat ik zien hoe de vragen randomizer werkt door middel van een visual sheet.

De code van deze feature kan je [hier](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/QuizGame/QuizManager.cs) vinden.

![QuizRandomSheet](https://github.com/Casdegraaff/ProeveVanBekwaamheid/assets/54799365/a8de44e7-5ecc-45dd-9674-1da3471860c8)

### flow chart vragen randomizer:

Hier laat ik zien hoe de vragen randomizer werkt door middel van een flow chart

<img src="https://cdn.discordapp.com/attachments/744949183479283785/1110140567326830672/RandomQuestionDiagram.png" data-canonical-src="https://cdn.discordapp.com/attachments/744949183479283785/1110140567326830672/RandomQuestionDiagram.png" height="700" width="449"/>

___

## Dialogue system gemaakt door Ruben


### Visual sheet dialogue system:
Hier laat ik zien de dialogue system werkt door middel van een visual sheet.

De code van deze feature kan je [hier](https://github.com/Casdegraaff/ProeveVanBekwaamheid/tree/Development/Assets/Scripts/DialogueScripts) vinden.

![DialogueSheet](https://github.com/Casdegraaff/ProeveVanBekwaamheid/assets/54799365/477dd76f-1edb-47f1-8296-5696298da956)


### Flow chart dialogue system:

<img src= https://cdn.discordapp.com/attachments/889445941717897246/1110849344699117578/Algorithm_flowchart_example_2.png height="700" width="449"/>

___

## Spel keuze animaties door Quinn

Hier laat ik zien hoe de keuze van een game werkt en wat er gebeurd als je op een scherm klikt(Oftewel kiezen van een van de 2 games). Het moment dat je over een scherm gaat highlight het scherm op en komt de naam van de game naar boven. Als je op een van de schermen klikt begint er een animatie te spelen.

De code van deze feature kan je [hier](https://github.com/Casdegraaff/ProeveVanBekwaamheid/blob/Development/Assets/Scripts/Animation/start_game.cs) vinden.

### Visual sheet scherm animaties:

![MonitorSheet](https://github.com/Casdegraaff/ProeveVanBekwaamheid/assets/54799365/2f469356-145d-4627-af6a-6a42b6d050a4)

### flow chart scherm animaties

![Blank diagram](https://github.com/Casdegraaff/ProeveVanBekwaamheid/assets/54802902/9c0364c7-d504-48b7-8457-2a026134884d)

