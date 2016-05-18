local L = AceLibrary("AceLocale-2.2"):new("XLoot")

L:RegisterTranslations("frFR", function()
    return {
		catSnap = "Comportement de la fen\195\170tre",
		catLoot = "Comportement du Loot",
		catFrame = "Options de la fen\195\170tre",
		catInfo = "Information du Loot",
		catGeneralAppearance = "Apparence g\195\169n\195\169rale",
		catFrameAppearance = "Apparence de la fen\195\170tre",
		catLootAppearance = "Apparence du Loot",
		catExtras = "Extras",
		
		optLock = "V\195\169rouiller la fen\195\170tre",
		optOptions = "Options de l'interface",
		optBehavior = "Options du comportement",
		optCursor = "Affiche la fen\195\170tre XLoot sous le curseur",
		optSmartsnap = "Affichage intelligent sous le curseur",
		optSnapoffset = "D\195\169calage de l'affichage",
		optCollapse = "Referme les boutons de loot",
		optDragborder = "Bordure d\195\169pla\195\167able",
		optLootexpand = "Largeur automatique de la fen\195\170tre pour le nom des loots",
		optAltoptions = "Alt+CliqueDroit Affiche le menu",
		optSwiftloot = "Ne pas afficher la fen\195\170tre quand Shift est utilis\195\169",
		optQualitytext = "Afficher la raret\195\169 des objets",
		optInfotext = "Afficher les informations des objets",
		optLinkAll = "Boutton Montrer tout",
		optLinkAllVis = "Visible: ",
		optLinkAllThreshold = "Seuil pour Montrer tout",
		optLinkAllChannels = "Toujours montrer vers...",
		optAppearance = "Apparence",
		optQualityborder = "Couleur de la bordure suivant la raret\195\169",
		optQualityframe = "Couleur de fond suivant la raret\195\169",
		optLootqualityborder = "Couleur de la bordure du loot suivant la raret\195\169",
		optBgcolor = "Couleur de fond de la fen\195\170tre",
		optBordercolor = "Couleur de la bordure de la fen\195\170tre",
		optTexColor = "Couleur de l'icone du loot suivant la raret\195\169",
		optHighlightLoot = "Surligner la raret\195\169 du loot",
		optHighlightThreshold = "Seuil du surlignement de la raret\195\169 du loot", 
		optLootbgcolor = "Couleur de fond du loot",
		optLootbordercolor = "Couleur de la bordure du loot",
		optScale = "Echelle",
		optAdvanced = "Options avanc\195\169es",
		optDebug = "Messages de debuggage",
		optDefaults = "R\195\169initialisation des options",
		
		descLock = "Rendre la fen\195\170tre de loot fixe",
		descOptions = "Afficher le menu d\195\169roulant des options",
		descBehavior = "Changer le comportement de Xloot",
		descCursor = "Affiche la fen\195\170tre de loot sous le curseur quand vous ramassez quelque chose",
		descSmartsnap = "La fen\195\170tre de loot reste verticale au curseur quand la liste change apr\195\168s avoir ramass\195\169 un objet",
		descSnapoffset = "Fixe la distance depuis le milieu du premier icone de loot pour l'affichage sous le curseur, et ce horizontalement",
		descCollapse = "R\195\169duit les objets vid\195\169s et place le curseur sur la prochaine fen\195\170tre si l'option du curseur est activ\195\169e.",
		descDragborder = "Autorise le d\195\169placement de la fen\195\170tre de loot par sa bordure, afin d'\195\169viter de rammasser un objet pour effectuer un d\195\169placement",
		descLootexpand = "Largeur de la fen\195\170tre en fonction des noms. Des noms courts donnent une petite fen\195\170tre, des noms longs donnent une grande fen\195\170tre",
		descAltoptions = "Alt+CliqueDroit sur un loot vous permet d'afficher le menu de Xloot. Peut \195\170tre d\195\169sactiv\195\169 pour \195\169viter des interf\195\169rences avec d'autres mods.",
		descSwiftloot = "Essaye de d\195\169terminer si le ramassage s'est fait avec shift enfonc\195\169, et ne pas afficher la fen\195\170tre s'il y a de la place pour tout prendre. Cela devrait r\195\169duire le lag lors de l'utilisation du shift. A d\195\169sactiver en cas de probl\195\168me.",
		descQualitytext = "Affiche une ligne suppl\195\169mentaire au dessus du nom de l'objet pour sa raret\195\169",
		descInfotext = "Affiche une ligne suppl\195\169mentaire sous le nom de l'objet pour les informations",
		descLinkAll = "Affiche le boutton Montrer tout, bouton qui fera appara\195\174tre un menu avec l'ensemble des canaux disponibles vers lesquels vous montrerez les loot.",
		descLinkAllVis = "Quand le bouton Montrer tout doit \195\170tre visible",
		descLinkAllThreshold = "Ins\195\168re uniquement les objets dont la raret\195\169 est sup\195\169rieure au seuil fix\195\169.",
		descLinkAllChannels = "Toujours montrer vers ces cannaux lors d'un clique-gauche sur Montrer tout. |cFFFF0000Si aucun cannal n'est s\195\169lectionn\195\169, cliquer-gauche sur Montrer tout affichera alors son menu.|r",
		descAppearance = "Couleur, \195\169chelle et skin de la fen\195\170tre principale et de ses sous-ensembles",
		descQualityborder = "Couleur de la bordure de la fen\195\170tre des loots en accord avec la plus grande raret\195\169",
		descQualityframe = "Couleur du fond de la fen\195\170tre des loots en accord avec la plus grande raret\195\169",
		descLootqualityborder = "Couleur de la bordure des loots suivant sa raret\195\169",
		descHighlightLoot = "Surligne chaque loot par sa raret\195\169",
		descHighlightThreshold = "Raret\195\169 minimum permettant le surlignement de la fen\195\170tre",
		descBgcolor = "Changer la couleur du fond de la fen\195\170tre elle-m\195\170me",
		descBordercolor = "Changer la couleur de bordure de la fen\195\170tre elle-m\195\170me",
		descTexColor = "Couleur de l'icone/texture de l'objet suivant sa raret\195\169",
		descLootbgcolor = "Changer la couleur de fond de chaque objet ramass\195\169",
		descLootbordercolor = "Changer la couleur de la bordure de chaque objet ramass\195\169",
		descScale = "Echelle de la fen\195\170tre de loot",
		descAdvanced = "Options que vous ne devriez pas toucher, \195\160 votre discr\195\169tion.",
		descDebug = "Afficher les messages de debugging",
		descDefaults = "R\195\169initialiser compl\195\168tement Xloot (fen\195\170tre et options)",
		
		qualityQuest = "Objet de qu\195\170te",
		
		guiTitle = "Options de XLoot",
		
		itemWeapon = "Arme",
		
		evHerbs = "Cueillette",
		evOpenNT = "Ouverture - pas de texte",
		evOpen = "Ouverture",
		
		linkallloot = "Montrer tout...",
		}
end)
