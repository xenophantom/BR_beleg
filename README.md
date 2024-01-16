Marie Repmann (49609), Lloyd König (50284), Felizitas Ebermann (49801) und Theresa Minister (49644)

*Projektabgabe: 16.01.2024*

# Eisabenteuer

In „Eisabenteuer“werden die Spieler in die frostige Welt der Arktis entführt. Hier findet man sich auf einer Eisscholle mitten im weiten Ozean wieder. Als Spieler*in muss man schnell und geschickt entscheiden, wo lang zu fahren ist, um nicht gegen einen Eisberg zu stoßen.. Geplant ist ein Endlosmodus, bei dem man möglichst lange durchhält, ohne ins eiskalte Wasser zu fallen.

![](https://github.com/xenophantom/BR_beleg/blob/main/Pasted%20image%2020240116095340.png)

## Anleitung

Die [.exe](https://github.com/xenophantom/BR_beleg/blob/main/BuildSettings/BR_beleg.exe) befindet sich im Ordner Build Settings. Diese enthält das Spiel zum Testen.

Im [Asset-Ordner](https://github.com/xenophantom/BR_beleg/tree/main/Assets) befinden sich alle Materialien, die verwendet wurden. Der Ordner folgt der internen Struktur, die in Unity im Projekt angelegt wurde. Alle Dateien mit der Endung `.cs` enthalten die Skripte.

### Shader

![](https://github.com/xenophantom/BR_beleg/blob/main/Screenshot%202024-01-16%20103142.png)

## SOLL FEATURES

1. Spielcharakter: ~~nur Sprungbewegung auf neue Scholle~~, unanimiert
2. Eisscholle: bewegbares Element, das durch die Spielumgebung zu navigieren ist
	- Bewegung mit Pfeiltasten oder Mausschwenk
	- ~~Eistextur mit Reflexion und Transluzenz~~
3. Spielumgebung:
	- Eisberge als Hindernisse, diese erben Textur von der Scholle, sind aber "feindseliger" geformt (z.B. mit Zacken) und deren Collision Mechanics
	- Wassershader mit entsprechenden physikalischen Eigenschaften
	- (De-)Spawn von weiteren Eisschollen und Hindernissen, basierend auf Kamerasichtbarkeit
4. Rotierende Wasserschicht:
	Um eine Vorwärtsbewegung zu simulieren, könnten wir eine rotierende Ebene implementieren, auf der dann Spielelemente nach Kamerasichtbarkeit eingeblendet werden können (siehe Punkt 3). Allerdings können wir noch nicht einschätzen, inwiefern die Beleuchtungsmodelle hier funktionieren, wir möchten zum Beispiel, dass Elemente des Hintergrunds auch im Wasser reflektiert werden. Wir müssen also vorher testen, ob die unterschiedlichen Ebenen interagieren können.

![](https://github.com/xenophantom/BR_beleg/blob/main/sketch_game_mechanism.png)
![](https://github.com/xenophantom/BR_beleg/blob/main/Pasted%20image%2020240116095625.png)

## KANN FEATURES

1. Charakteranimation für die Sprungbewegung
2. Schollenmechanismus:
	Mittels Timer schmilzt oder bricht die Scholle, um den Spielverlauf noch hektischer zu gestalten. Auch könnte man das Verhalten der Scholle komplexer gestalten: wenn man mit einem Eisberg kollidiert, könnten auch nur Teile abbrechen, anstatt dass die Scholle komplett zerbricht.
1. Interaktion von der Scholle mit der Wasserbewegung:
	Die Eisscholle könnte sich mit der Strömung des Wassers bewegen. Hier entsteht dann auch das Potenzial für eine weitere Schwierigkeitsstufe: der\*die Spieler\*in müsste die Scholle ausbalancieren, damit der Charakter nicht hinunter schlittert.
1. Himmeldetails:
	Szenerie mit animierten Polarlichtern und funkelnden Sternen statt statischem Hintergrund
1. **Rudimentäres Spielmenü + Game Over Bildschirm mit High Score** → wurde umgesetzt
2. Schwierigkeitsgrad des Spiels mit der Zeit erhöhen: z.B. Schnellerwerden der Wasserströmung

## PROJEKTABLAUF UND ENTWICKLUNGSUMGEBUNG

Da wir Game Mechanics und nicht nur Visualisierung entwickeln möchten, haben wir uns für Unity entschieden. So können wir uns auch ausreichend auf die Optik der Szenerie konzentrieren, da uns die Spielmechanismen durch die Engine vereinfacht werden. Für Version Control nutzen wir Github.

Die Kommunikation läuft über Discord, den Projektbericht erstellen wir mit Google Docs.

**Oktober**

Konzept erarbeiten, Entwicklungsumgebung + Version Control einrichten

**November**

Einarbeiten in Unity + Grundgerüst erstellen (Objekte ohne Shader, Game Mechanics testen)

**Dezember**

Shader + Texturen einbauen, Kann Features in Erwägung ziehen

**Januar**

Optimierung, Bugs
