# Application de messagerie – Frontend WPF

Cette application propose une interface moderne pour échanger des messages, gérer ses contacts et se connecter de façon sécurisée. Elle est conçue en WPF (.NET) et suit l’architecture MVVM pour une organisation claire et évolutive.

## Fonctionnalités principales
- **Authentification** : connexion sécurisée des utilisateurs.
- **Gestion des messages** : envoi, réception et affichage des conversations.
- **Gestion des contacts** : ajout, consultation et sélection de contacts pour discuter.
- **Navigation fluide** : passage intuitif entre les différentes vues (connexion, chat, etc.).

## Organisation du projet
- La logique de présentation est séparée des vues pour faciliter la maintenance et les évolutions.
- Les modèles représentent les données principales (utilisateur, message).
- Les services gèrent la communication avec le backend, l’authentification et la gestion des messages.
- Les utilitaires facilitent la navigation et d’autres fonctionnalités transverses.
- Les commandes permettent de lier les actions de l’interface à la logique métier.

## Backend
Le backend, développé en microservices .NET C#, est disponible ici : [messaging-app](https://github.com/AlphaEngineer54/messaging-app)
