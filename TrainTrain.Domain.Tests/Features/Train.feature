Fonctionnalité: Réservation de places dans plusieurs wagon (un train)

Scénario: Train avec wagon 1 à 70% et wagon 2 vide, réservation de 4
  Etant donné un premier wagon occupé à 70%
  Et un deuxième wagon vide
  Quand on réserve 4 places
  Alors la réservation est validée
  Et le prix est de 200 €
  Et il y a 70 places occupées dans le premier wagon
  Et il y a 4 places occupées dans le deuxième wagon
  
Scénario: Train avec wagon 1 à 65% et wagon 2 vide, réservation de 10
  Etant donné un premier wagon occupé à 65%
  Et un deuxième wagon vide
  Quand on réserve 10 places
  Alors la réservation est validée
  Et le prix est de 500 €
  Et il y a 65 places occupées dans le premier wagon
  Et il y a 10 places occupées dans le deuxième wagon

Scénario: Train avec wagon 1 à 65% et wagon 2 à 66%, réservation de 10
  Etant donné un premier wagon occupé à 65%
  Et un deuxième wagon occupé à 66%
  Quand on réserve 10 places
  Alors la réservation est annulée
  Et il y a 65 places occupées dans le premier wagon
  Et il y a 66 places occupées dans le deuxième wagon