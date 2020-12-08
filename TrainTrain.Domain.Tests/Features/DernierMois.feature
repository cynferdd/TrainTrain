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
