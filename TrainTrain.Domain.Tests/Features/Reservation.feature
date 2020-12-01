Fonctionnalité: Réservation de places avec prise en compte du délai avant la validité du billet au moment de la réservation

Scénario: Prix à la bourre
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs une semaine avant le départ :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
Alors la réservation est validée
Et le prix est de 60 €

Scénario: Prix prem's
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs dans le premier mois de mise à disposition de la réservation :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
Alors la réservation est validée
Et le prix est de 30 €