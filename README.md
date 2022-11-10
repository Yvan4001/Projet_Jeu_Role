# Projet formation Dawan en C#/.Net : Jeu RPG à choix multiples

## Objectif 1 : Création d'un joueur / inscription au jeu
Un joueur doit pouvoir se créer un personnage. Pour cela il a :
- Id (Int)
- Pseudo (string)
- Objects clés (types ObjetsCles)
- Objets (string - a définir)

## Objectif 2 : Création et récupération des objets clés
Les objets clés vont permettre de savoir où en est le joueur dans le scénario. Selon s'il a ou non récupéré un objet de quête ou s'il l'a rendu pour récupérer une récompense, on pourra connaître son avancement.
Objet clé :
- Id (int)
- Nom (string)
- Obtenu (bool : True -> Il a récupéré, False -> Pas encore récupéré)

## Objectif 3 : Ajouts de jobs/rôles et autres options
- [ ] Créer un système de rôles et jobs pour le joueur et qu'il pourra choisir à la création du personnage.
- [ ] On pourra aussi envisager un système de combat s'il y a le temps.
