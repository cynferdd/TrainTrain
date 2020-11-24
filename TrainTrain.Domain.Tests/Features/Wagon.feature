Fonctionnalité: Réservation de wagon

Scénario: Wagon vide et on réserve une place à 50 €
  Etant donné un wagon qui contient 100 places
  Et aucune place n'est réservée
  Quand on réserve 1 place
  Alors la réservation est validée
  Et le prix est de 50 €
  Et il y a 1 place occupée dans le wagon

Scénario: Wagon vide et on réserve 4 places à 50 € chacune
  Etant donné un wagon qui contient 100 places
  Et aucune place n'est réservée
  Quand on réserve 4 places
  Alors la réservation est validée
  Et le prix est de 200 €
  Et il y a 4 places occupées dans le wagon

Scénario: Wagon à 70% de capacité et on empêche ma réservation d'1 place
  Etant donné un wagon qui contient 100 places
  Et 70 places sont occupées
  Quand on réserve 1 place
  Alors la réservation est annulée
  Et il y a 70 places occupées dans le wagon

Scénario: Wagon à 65% de capacité et on empêche ma réservation de 10 places
  Etant donné un wagon qui contient 100 places
  Et 65 places sont occupées
  Quand on réserve 10 places
  Alors la réservation est annulée
  Et il y a 65 places occupées dans le wagon