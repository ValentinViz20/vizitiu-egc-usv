# Raspunsuri Laborator 3
```
Vizitiu Valentin Iulian
Grupa 3133A
```


1. **Care este ordinea de desenare a vertexurilor pentru aceste metode
(orar sau anti-orar)? Desenați axele de coordonate din aplicația-
template folosind un singur apel GL.Begin().**
   
Ordinea in care vertex-urile sunt desenate este acea in care apealam metodele GL.Vertex.
Daca este anti-orar, atunci consideram ca poligonul este cu fata catre utilizator.

2. **Ce este anti-aliasing? Prezentați această tehnică pe scurt.**

Anti-aliasing este o metoda pentru a reduce artefactele vizuale care apar cand randam imagini la rezolutii mai 
mici. Aceste artefacte sunt cauzate de din cauza ca pixeli nu pot reprezenta suprafete curbate, linii, etc prea bine.

Anti-aliasing functioneaza prin folosirea supersampling, multisampling sau post-processing filters.

3. **Care este efectul rulării comenzii GL.LineWidth(float)? Dar pentru
GL.PointSize(float)? Funcționează în interiorul unei zone
GL.Begin()?**

GL.LineWidth(float) - mareste grosimea liniilor desenate.
GL.PointSize(float) - mareste marimea punctelor desenate.
Aceste metode nu functioneaza in interiorul zonei GL.Begin().

4. **Răspundeți la următoarele întrebări (utilizați ca referință eventual și
tutorii OpenGL Nate Robbins):**

- Care este efectul utilizării directivei LineLoop atunci când
desenate segmente de dreaptă multiple în OpenGL?
  - Se vor desena linii, unde cel deal doilea punct al unei linii, va fi folosit ca primul puncat al urmatoarei linii.
Iar la final se vor uni primul si ultimul punct pentru a crea o bucla.

- Care este efectul utilizării directivei LineStrip atunci când
desenate segmente de dreaptă multiple în OpenGL?
  - La fel ca la line loop, doar ca ultimul si primul punct nu vor fi unite,

- Care este efectul utilizării directivei TriangleFan atunci când
desenate segmente de dreaptă multiple în OpenGL?
     - Se va defini un punct central, iar apoit punctele din jurul acestui punct se vor unit cu cel central, la fel ca un ventilator (fan)

- Care este efectul utilizării directivei TriangleStrip atunci când
desenate segmente de dreaptă multiple în OpenGL?
    - Va face ca un punct sa fie conectat la ultimele 2 puncte, la fel ca o fasie (strip)

6. **Urmăriți aplicația „shapes.exe” din tutorii OpenGL Nate Robbins.
De ce este importantă utilizarea de culori diferite (în gradient sau
culori selectate per suprafață) în desenarea obiectelor 3D? Care este
avantajul?**

Deoarece fara unmbre sau shadere, nu vom percepe nici o forma, ci doar o simgura culoare intr-o forma ciudata.

7. **Ce reprezintă un gradient de culoare? Cum se obține acesta în
OpenGL?**

Un gradient reprezinta o trecere liniara de la o culoare la alta. 
Pentru a obtine aceste efect in OpenGL, putem da culori diferite vertex-elor cand desemam poligoane.

