# GachaTOL
For testing purpose only.


French description only


<h1>Simulation gacha de Tales of Link.</h1>

Cette simulation repose sur des connaissances empiriques du gacha.


<h2>Description du programme :</h2>


* En exécutant le programme, il va d'abord afficher les chances d'avoir tel ou tel rareté.

Le numéro 1 symbolise les 3\* dans Tales of Link.

Le numéro 2 symbolise les 4\* dans Tales of Link.

Le numéro 3 symbolise les 5\* dans Tales of Link.

* Les valeurs initiales sont censées être respectivement 64 %, 30 % et 6 %, mais le C# en a décidé autrement et c'est donc approximatif.

* Ensuite, il va demander d'entrer un chiffre.

Chaque chiffre correspond à une invocation particulière.

* On peut en relancer autant qu'on veut à condition de ne pas indiquer un mauvais chiffre !


<h2>Description du fonctionnement interne du programme :</h2>


* Un gacha est symbolisé dans ce programme par une liste de 100 entiers. Ces entiers peuvent aller de 1 à 3.

* Le programme va déterminer les chances de ces entiers et les entrer dans un ordre fixe dans le tableau.

* Il va ensuite lancer un algorithme qui va réarranger ce tableau pour que les valeurs soient totalement random dans leur emplacement.

* Après quoi, il lancement un random pour trouver une valeur dans le tableau.

* À la fin, il n'y aura plus qu'à faire une petite interface pour lancer le gacha.

<h2>Différentes options du programme :</h2>

* Numéro 1 : Si vous tapez 1, vous allez faire une seule invocation. La première donnera forcément la valeur 2 ou plus. Les suivantes, ça prendra en compte la valeur 1.

* Numéro 2 : C'est une invocation multiple de 10 invocations.  Il y aura une garantie de tomber parmi les 10 sur au moins 2 valeurs supérieures ou égales à 2. Pour chaque invocation, la valeur donnée sera prise dans la même liste.

* NUméro 3 : C'est aussi une invocation multiple de 10 invocations avec une garantie de tomber sur au moins 2 valeurs supérieures ou égales à 2.  La seule différences est que pour chaque invocation, une nouvelle liste sera générée à chaque fois.

* Numéro 4 : C'est la même chose que le numéro 2, sauf qu'on ajoute une possibilité de tomber sur une valeur 2 ou 3 obligatoirement featured. Le featured est à peut près le même délire que la garantie de tomber sur une valeur supérieure ou égale à 2 dans ce programme. Les chances de tomber sur 2 est de 83 % et sur 3, 17 %.

* Numéro 5  : Même chose que le numéro 4. Cette fois-ci le taux est changé. Il y a 94 % de chance de tomber sur la valeur 2, et 6 % de chance de tomber sur la valeur 3.

* Numéro 6  : C'est le numéro 3 avec le featured du numéro 4.

* Numéro 7 : C'est le numéro 6 avec les chances du numéro 5.

* Numéro 8  : Ça vous dira « Au revoir » et ça fermera le programme.

*  Autre chose : Ça claquera un message d'erreur  et ça fermera le programme.

<h2>Remarques à signaler</h2>

* Il y a bizarrement de grosses chances de tomber sur la valeur 3 (une 5\* dans Tales of Link) en invocation normale. Ce qui n'est pas le cas dans Tales of Link (donc il y a un problème quelque part à ce niveau).

* Il y a peu de chance de tomber sur une featured 3 (une 5\*), ce qui n'est pas normale (ou si ?).

<h2>Mise à jour</h2>

Je ferai une mise à jour du programme quand j'aurai plus de données concernant le gacha.

<h2>Utilisation</h2>

* Vous êtes libre de partager, discuter, améliorer, cacher, voler, manger, critiquer, insulter, rigoler, détruire, changer le programme comme bon vous semble. Je me réserve le droit de récupérer les améliorations constructives pour justement améliorer le programme (et qu'il ressemble le plus à celui de Tales of Link).
