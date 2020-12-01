Fonctionnalité: Réservation de places avec prise en compte des réductions

Scénario: Train vide avec une réservation utilisant une carte 12-25
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |     12-25      |
Alors la réservation est validée
Et le prix est de 25 €