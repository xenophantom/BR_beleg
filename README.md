Marie Repmann (49609), Lloyd König (50284), Felizitas Ebermann (49801) und Theresa Minister (

Projektabgabe: 16.01.2024

# Eisabenteuer

In „Eisabenteuer“ werden die Spieler in die frostige Welt der Arktis entführt. Hier findet man sich auf einer Eisscholle mitten im weiten Ozean wieder. Als Spieler*in muss man schnell und geschickt entscheiden, wo lang zu fahren ist, um nicht gegen einen Eisberg zu stoßen.. Geplant ist ein Endlosmodus, bei dem man möglichst lange durchhält, ohne ins eiskalte Wasser zu fallen.

[Bild zum Spielmodus]

## PROJEKTABLAUF UND ENTWICKLUNGSUMGEBUNG
Da wir Game Mechanics und nicht nur Visualisierung entwickeln möchten, haben wir uns für Unity entschieden. So können wir uns auch ausreichend auf die Optik der Szenerie konzentrieren, da uns die Spielmechanismen durch die Engine vereinfacht werden. Für Version Control nutzen wir Github.
Die Kommunikation läuft über Discord, den Projektbericht erstellen wir mit Google Docs.
[Timeline anpassen/überarbeiten]
Oktober
Konzept erarbeiten, Entwicklungsumgebung + Version Control einrichten
November
Einarbeiten in Unity + Grundgerüst erstellen (Objekte ohne Shader, Game Mechanics testen)
Dezember
Shader + Texturen einbauen, Kann Features in Erwägung ziehen
Januar
Optimierung, Bugs
[Features überarbeiten]
SOLL FEATURES
Spielcharakter: Nur Sprungbewegung auf neue Scholle, unanimiert
Eisscholle: Bewegbares Element, das durch die Spielumgebung zu navigieren ist
Bewegung mit Pfeiltasten oder Mausschwenk
Eistextur mit Reflexion und Transluzenz
Spielumgebung:
Eisberge als Hindernisse, diese erben Textur von der Scholle, sind aber "feindseliger" geformt (z.B. mit Zacken) und deren Collision Mechanics 
Wassershader mit entsprechenden physikalischen Eigenschaften
(De-)Spawn von weiteren Eisschollen und Hindernissen, basierend auf Kamerasichtbarkeit
Rotierende Wasserschicht:
Um eine Vorwärtsbewegung zu simulieren, könnten wir eine rotierende Ebene implementieren, auf der dann Spielelemente nach Kamerasichtbarkeit eingeblendet werden können (siehe Punkt 3). Allerdings können wir noch nicht einschätzen, inwiefern die Beleuchtungsmodelle hier funktionieren, wir möchten zum Beispiel, dass Elemente des Hintergrunds auch im Wasser reflektiert werden. Wir müssen also vorher testen, ob die unterschiedlichen Ebenen interagieren können.
 
KANN FEATURES
Charakteranimation für die Sprungbewegung
Schollenmechanismus: 
Mittels Timer schmilzt oder bricht die Scholle, um den Spielverlauf noch hektischer zu gestalten. Auch könnte man das Verhalten der Scholle komplexer gestalten: wenn man mit einem Eisberg kollidiert, könnten auch nur Teile abbrechen, anstatt dass die Scholle komplett zerbricht.
Interaktion von der Scholle mit der Wasserbewegung: 
Die Eisscholle könnte sich mit der Strömung des Wassers bewegen. Hier entsteht dann auch das Potenzial für eine weitere Schwierigkeitsstufe: der*die Spieler*in müsste die Scholle ausbalancieren, damit der Charakter nicht hinunter schlittert.
Himmeldetails: 
Szenerie mit animierten Polarlichtern und funkelnden Sternen statt statischem Hintergrund
Rudimentäres Spielmenü + Game Over Bildschirm mit High Score
Schwierigkeitsgrad des Spiels mit der Zeit erhöhen: z.B. Schnellerwerden der Wasserströmung
[Funktionalitäten erklären + Codepassagen]
[Gestaltung]
[Schwierigkeiten]
