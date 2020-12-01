Fonctionnalité: Réservation de places avec prise en compte du délai avant la validité du billet au moment de la réservation

Scénario: Prix à la bourre
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs <DelaiReservation> avant le départ :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
Alors la réservation est validée
Et le prix est de 60 €
Exemples:
|DelaiReservation|
|  Une semaine   |
|   Un mois      |
|   Deux jours   |
|  Deux semaines |
| Trois semaines |

Scénario: Prix prem's
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs <DelaiReservation> après le début de mise à disposition de la réservation :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
Alors la réservation est validée
Et le prix est de 30 €
Exemples:
|DelaiReservation|
|  Une semaine   |
|   Un mois      |
|   Deux jours   |
|  Deux semaines |
| Trois semaines |

Scénario: Prix normal
Etant donné un train avec les wagons suivants :
| Numero | NbPlaces | Occupation |
|    1   |    100   |    0%      |
|    2   |    100   |    0%      |
Quand on réserve pour ces voyageurs <DelaiReservation> après le début de mise à disposition de la réservation :
| Nom  | Prenom | CarteReduction |
| Toto |  Titi  |                |
Alors la réservation est validée
Et le prix est de 50 €
Exemples:
|DelaiReservation     |
|  Un mois et Un jour |
|  Deux mois          |
|  Trois mois -1 jour |