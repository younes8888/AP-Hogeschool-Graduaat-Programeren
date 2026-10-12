# page-layout

Bouw het gegeven ontwerp na met behulp van een CSS Grid.

* Zorg dat de body-tag altijd minstens `100vh` hoog is. (`min-height: 100vh`)
* Voeg de volgende elementen toe aan de body van je `index.html` pagina.
  * header
  * main
  * aside
  * footer
* Zorg dat elk van deze elementen 5px padding heeft (volledig rondom) 
* Zorg dat de naam van elk element in het bijhorende element staat. Geef ze het lettertype `Arial` en zorg voor een fallback naar eender welk `sans-serif` font.
* selecteer deze elementen vanuit CSS met type-selectors
* geef de volgende achtergrondkleuren aan elk element: 
  * header: `#91c8ff`
  * main: `#7da9d5`
  * aside: `#007fff`
  * footer: `#588ec3`
* selecteer de parent van de voorgaande elementen met een type-selector en pas het grid toe. Let daarbij dat de aside 1/5 van de schermbreedte inneemt.

### Extra:

Maak deze oefening nu ook een keer met named areas:
  * geef elk grid-child een naam (met de property `grid-area`) zodat je ze kunt gebruiken in een grid.

    > **TIP**: Opgelet: de value moet NIET tussen quotes ("") staan.

  * geef de grid-parent de `grid-template-areas` property.

## Verwacht resultaat

![page-layout](./opgave.webp)

De grid-lijnen zoals je ze in de DevTools van je browser te zien krijgt:

![grid-instellingen](./grid-settings.png)
