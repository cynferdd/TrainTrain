Fonctionnalité: Réservation de places dans plusieurs wagon (un train)

Scénario: Train avec wagon 1 à 70% et wagon 2 vide, réservation de 4
  Etant donné un train avec les wagons suivants :
    | Numero | NbPlaces | Occupation |
    |    1   |    100   |    70%     |
    |    2   |    100   |    0%      |
  Quand on réserve 4 places
  Alors la réservation est validée
  Et le prix est de 200 €
  Et les wagons sont composés comme ceci :
    | Numero | NbPlacesOccupees |
    |    1   |     70           |
    |    2   |     4            |
  
  
Scénario: Train avec wagon 1 à 65% et wagon 2 vide, réservation de 10
  Etant donné un train avec les wagons suivants :
    | Numero | NbPlaces | Occupation |
    |    1   |    100   |    65%     |
    |    2   |    100   |    0%      |
  Quand on réserve 10 places
  Alors la réservation est validée
  Et le prix est de 500 €
  Et les wagons sont composés comme ceci :
    | Numero | NbPlacesOccupees |
    |    1   |     65           |
    |    2   |     10           |

Scénario: Train avec wagon 1 à 65% et wagon 2 à 66%, réservation de 10
  Etant donné un train avec les wagons suivants :
    | Numero | NbPlaces | Occupation |
    |    1   |    100   |    65%     |
    |    2   |    100   |    66%     |
  Quand on réserve 10 places
  Alors la réservation est annulée
  Et les wagons sont composés comme ceci :
    | Numero | NbPlacesOccupees |
    |    1   |     65           |
    |    2   |     66           |

Scénario: Train avec wagon 1 à 70% et wagon 2 à 72% et wagon 3 vide, réservation de 4
  Etant donné un train avec les wagons suivants :
    | Numero | NbPlaces | Occupation |
    |    1   |    100   |    70%     |
    |    2   |    100   |    72%     |
    |    3   |    100   |     1%     |
  Quand on réserve 4 places
  Alors la réservation est validée
  Et le prix est de 200 €
  Et les wagons sont composés comme ceci :
    | Numero | NbPlacesOccupees |
    |    1   |     70           |
    |    2   |     72           |
    |    3   |      5           |

Scénario: Train avec wagon 1 à 200 places dont 70 occupées et wagon 2 vide, réservation de 4
  Etant donné un train avec les wagons suivants :
    | Numero | NbPlaces | Occupation |
    |    1   |    200   |    35%     |
    |    2   |    200   |    0%      |
  Quand on réserve 4 places
  Alors la réservation est validée
  Et le prix est de 200 €
  Et les wagons sont composés comme ceci :
    | Numero | NbPlacesOccupees |
    |    1   |     74           |
    |    2   |     0            |