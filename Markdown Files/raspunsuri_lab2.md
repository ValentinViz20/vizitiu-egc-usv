# Raspunsuri Laborator 2
```
Vizitiu Valentin Iulian
Grupa 3133A
```

1. **Ce este un viewport?**

Un viewport este o zona din drawing buffer ce determina care elementele grafice si ce parti din ele for fi afisate pe ecran.

2. **Ce reprezintă conceptul de frames per seconds din punctul de vedere al bibliotecii OpenGL?**

Din punctul de vedere al OpenGL, FPS reprezinta numarul de cadre care pot fi randate si afisate pe ecran intr-o secunda.

3. **Când este rulată metoda OnUpdateFrame()?**

Metoda OnUpdateFrame() este apelata inaintea metodei OnRenderFrame(), pentru fiecare cadru randat.

4. **Ce este modul imediat de randare?**

Modul imediat de randare este un mod deprecat de radare al OpenGL, care presupune apealarea GL.Begin() si GL.End(), iar
intre aceste metode sunt desenate vertex-uri. Modul imediat este mai simplu de folosit, dar are preformante mai proste.

5. **Care este ultima versiune de OpenGL care acceptă modul imediat?**

OpenGL 2.1

6.  **Când este rulată metoda OnRenderFrame()?**

La fiecare randare a unui cadre. Daca avem 60 FPS, metoda este apelata de 60 ori pe secunda.

7. **De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?**

Deoarece la inceput fereastra are marimea 0x0, si aveam nevoie sa configuram OpenGL pentru a randa corect pe rezolutia 
ferestrei care o dorim.

8. **Ce reprezintă parametrii metodei
CreatePerspectiveFieldOfView() și care este domeniul de valori
pentru aceștia?**

Metoda CreatePerspectiveFieldOfView() creaza campul in care vedem pe ecran.

Un parametru cu care poate fi apelata este MathHelper.DegreesToRadians(60), care reprezinta un FOV de 60 grade.
zNear - obiectele la o distanta mai mica nu vor fi randate pe ecram
zFar - obiectele la o distanta mai mare nu vor fi randate pe ecran
aspect - aspectul ecranului