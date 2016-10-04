# GachaTOL
For testing purpose only.

French description only

Simulation gacha de Tales of Link.
Cette simulation repose sur des connaissances empiriques du gacha.

Description du programme :
En exécutant le programme, il va d'abord afficher les chances d'avoir tel ou tel rareté.
Le numéro 1 symbolise les 3* dans Tales of Link.
Le numéro 2 symbolise les 4* dans Tales of Link.
Le numéro 3 symbolise les 5* dans Tales of Link.
Les valeurs initiales sont censées être respectivement 64 %, 30 % et 6 %, mais le C# en a décidé autrement et c'est donc approximatif.

Ensuite, il va demander d'entrer un chiffre.
Chaque chiffre correspond à une invocation particulière.
On peut en relancer autant qu'on veut à condition de ne pas indiquer un mauvais chiffre !

Description du fonctionnement interne du programme :

Un gacha est symbolisé dans ce programme par une liste de 100 entiers. Ces entiers peuvent aller de 1 à 3.
Le programme va déterminer les chances de ces entiers et les entrer dans un ordre fixe dans le tableau.
Il va ensuite lancer un algorithme qui va réarranger ce tableau pour que les valeurs soient totalement random dans leur emplacement.
Après quoi, il lancement un random pour trouver une valeur dans le tableau.
À la fin, il n'y aura plus qu'à faire une petite interface pour lancer le gacha.
