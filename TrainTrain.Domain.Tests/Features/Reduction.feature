Fonctionnalité: Réservation de places avec prise en compte des réductions

Scénario: Train vide avec une réservation sans carte de réduction
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
Alors la réservation est validée
Et le prix est de 50 €

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


Scénario: Train vide avec une réservation utilisant une carte Senior
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |     Senior     |
Alors la réservation est validée
Et le prix est de 37,5 €


Scénario: Train vide avec une réservation utilisant une carte Grand voyageur
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  | Grand Voyageur |
Alors la réservation est validée
Et le prix est de 40 €
  
Scénario: Train vide avec une réservation pour chaque type de réduction et un sans
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |     12-25      |
| Tata |  Tutu  |     Senior     |
| Tete |  Tyty  | Grand Voyageur |
| Cast |  Jean  |                |
Alors la réservation est validée
Et le prix est de 152,50 €