Sp�cification de la Rose dor�e (Gilded Rose)
Bonjour et bienvenue dans l'�quipe de la Rose dor�e.

Comme vous le savez, notre petite taverne situ�e � proximit� d'une cit� importante est dirig�e par l'amicale aubergiste Allison.

Nous achetons et vendons uniquement les meilleurs produits. Malheureusement, la qualit� de nos marchandises se d�grade constamment � l'approche de leur date de p�remption.

Un syst�me a �t� mis en place pour mettre � jour notre inventaire. Il a �t� d�velopp� par Leeroy, une personne pleine de bon sens qui est parti pour de nouvelles aventures.

Votre mission est d'ajouter une nouvelle fonctionnalit� � notre syst�me pour que nous puissions commencer � vendre un nouveau type de produit.

Mais d'abord, laissez-moi vous pr�senter notre syst�me :

Tous les �l�ments ont une valeur sellIn qui d�signe le nombre de jours restant pour vendre l'article.
Tous les articles ont une valeur quality qui d�note combien l'article est pr�cieux.
A la fin de chaque journ�e, notre syst�me diminue ces deux valeurs pour chaque produit.
Plut�t simple, non ?

Attendez, �a devient int�ressant :

Une fois que la date de p�remption est pass�e, la qualit� se d�grade deux fois plus rapidement.
La qualit� (quality) d'un produit ne peut jamais �tre n�gative.
"Aged Brie" augmente sa qualit� (quality) plus le temps passe.
La qualit� d'un produit n'est jamais de plus de 50.
"Sulfuras", �tant un objet l�gendaire, n'a pas de date de p�remption et ne perd jamais en qualit� (quality)
"Backstage passes", comme le "Aged Brie", augmente sa qualit� (quality) plus le temps passe (sellIn) ; La qualit� augmente de 2 quand il reste 10 jours ou moins et de 3 quand il reste 5 jours ou moins, mais la qualit� tombe � 0 apr�s le concert.
Nous avons r�cemment sign� un partenariat avec un fournisseur de produit invoqu� ("Conjured"). Cela n�cessite une mise � jour de notre syst�me :

les �l�ments "Conjured" voient leur qualit� se d�grader de deux fois plus vite que les objets normaux.
Vous pouvez faire les changements que vous voulez � la m�thode updateQuality et ajouter autant de code que vous voulez, tant que tout fonctionne correctement. Cependant, nous devons vous pr�venir, ne devez modifier en aucun cas la classe Item ou ses propri�t�s car cette classe appartient au gobelin de l'�tage et il rentrera dans une rage instantan�e et vous tuera sans d�lai : il ne croit pas dans le partage du code. (Vous pouvez ajouter une m�thode updateQuality et des propri�t�s statiques dans la classe Item si vous voulez, nous vous couvrirons)

Juste une pr�cision, un produit ne peut jamais voir sa qualit� augmenter au-dessus de 50, cependant "Sulfuras" est un objet l�gendaire et comme tel sa qualit� est de 80 et il ne change jamais.