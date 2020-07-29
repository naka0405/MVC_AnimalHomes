
var buttonAnimals = document.querySelector('.but_animals');
//buttonAnimals.addEventListener('click', GetAllAnimals, false);

var but_DarkMode = document.querySelector('.darkMode');
but_DarkMode.addEventListener('click', GetDarkMode, false)
function GetDarkMode(event) {
    let but_DarkMode = document.querySelector('.darkMode');
    if (event.target) {
        document.body.className = 'body_darkTheme'
    }
    let b = event.target;
    let a = b.parentNode;
   // a.appendChild(but_DarkMode);
    var but_lightMode = document.createElement('button');
    but_lightMode.className = 'lightMode';
    but_lightMode.innerText = 'light Mode';
    
    a.replaceChild(but_lightMode, but_DarkMode);
    but_lightMode.addEventListener('click', GetLightMode, false)
}
 function GetLightMode(event)
 {
     var but_lightMode = document.querySelector('.lightMode')
        document.body.className = 'body';
        var but_darkMode = document.createElement('button');
        but_darkMode.className = 'darkMode';
        but_darkMode.innerText = 'Dark Mode';
        let b = event.target;
        let a = b.parentNode;
     a.replaceChild(but_darkMode, but_lightMode);
     but_darkMode.addEventListener('click', GetDarkMode, false);
    }
    
