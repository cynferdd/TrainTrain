Fonctionnalité: Réservation de places avec prise en compte du délai avant la validité du billet au moment de la réservation

Scénario: Train vide avec une réservation faite 1 semaine avant le départ
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs une semaine avant le départ :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
Alors la réservation est validée
Et le prix est de 60 €