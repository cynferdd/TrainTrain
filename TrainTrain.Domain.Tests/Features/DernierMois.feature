Fonctionnalité: Réservation de places sur le dernier mois avec levée des 70% et possibilité de split

Scénario: dernier mois avec train à 80% et 70%, et 4 personnes réservent
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    80%     |
|    2   |    100   |    70%     |
Quand on réserve pour ces voyageurs Un mois avant le départ :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
| Tata |  Tyty  |                |
| Tutu |  Titi  |                |
| Tptp |  Tvtv  |                |
Alors la réservation est validée
Et le prix est de 240 €
Et les wagons sont composés comme ceci :
| Numero | NbPlacesOccupees |
|    1   |     80           |
|    2   |     74           |

Scénario: dernier mois avec train à 95% et 92%, et 10 personnes réservent (split)
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    95%     |
|    2   |    100   |    92%     |
Quand on réserve pour ces voyageurs Un mois avant le départ :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
| Tata |  Tyty  |                |
| Tutu |  Titi  |                |
| abcd |  Tvtv  |                |
| efgh |  Tvtv  |                |
| ijkl |  Tvtv  |                |
| mnop |  Tvtv  |                |
| qrst |  Tvtv  |                |
| uvwx |  Tvtv  |                |
| yzab |  Tvtv  |                |
Alors la réservation est validée
Et le prix est de 600 €
Et les wagons sont composés comme ceci :
| Numero | NbPlacesOccupees |
|    1   |     97           |
|    2   |     100          |

Scénario: dernier mois avec train à 95% et 92%, et 20 personnes réservent (impossible)
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    95%     |
|    2   |    100   |    92%     |
Quand on réserve pour ces voyageurs Un mois avant le départ :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
| Tata |  Tyty  |                |
| Tutu |  Titi  |                |
| abcd |  Tvtv  |                |
| efgh |  Tvtv  |                |
| ijkl |  Tvtv  |                |
| mnop |  Tvtv  |                |
| qrst |  Tvtv  |                |
| uvwx |  Tvtv  |                |
| yzab |  Tvtv  |                |
| abcd |  Tvtv  |                |
| 2ata |  Tyty  |                |
| 2utu |  Titi  |                |
| 2oto |  Titi  |                |
| 2fgh |  Tvtv  |                |
| 2jkl |  Tvtv  |                |
| 2nop |  Tvtv  |                |
| 2rst |  Tvtv  |                |
| 2vwx |  Tvtv  |                |
| 2zab |  Tvtv  |                |
Alors la réservation est annulée