
let fatherDiv = document.getElementById("container-cards-playlists");
let songinfoh3 = document.getElementById("songinfo_h3");
let songinfospan = document.getElementById("songinfo_span");
let songinfoimg = document.getElementById("songinfo_img");

class Card {
    constructor(i, t, s) {
        this.imagen = i;
        this.titulo = t;
        this.icono = s;
    }
    xImagen() {
        let source = this.imagen;

        return source
    }
    xTitulo() {
        let value = this.titulo;

        return value
    }
}

var coleccion = [];
coleccion.push(new Card("../adify/resources/images/image.png", "Fly", "fa fa-play"));
coleccion.push(new Card("../adify/resources/images/image.png", "Me", "fa fa-play"));
coleccion.push(new Card("../adify/resources/images/image.png", "To the", "fa fa-play"));
coleccion.push(new Card("../adify/resources/images/image.png", "Moon", "fa fa-play"));



let cantidad = toString(coleccion.length);

for (var x of coleccion) {
    let childDiv = document.createElement('div');
    childDiv.setAttribute("class", "card-playlist");
    let img = document.createElement('img');
    img.src = x.xImagen();
    fatherDiv.appendChild(childDiv);
    childDiv.appendChild(img)
    let info = document.createElement('div');
    info.setAttribute("class", "info");
    let span = document.createElement('span');
    span.textContent = x.xTitulo();
    info.appendChild(span);
    let botonDiv = document.createElement('div');
    botonDiv.setAttribute("class", "button-play");
    let boton = document.createElement('span');
    boton.setAttribute("class", "fa fa-play");
    boton.setAttribute("aria-hidden", "true");
    botonDiv.appendChild(boton);

    childDiv.appendChild(info);
    childDiv.appendChild(botonDiv);
}

let fatherDivPodcast = document.getElementById("container-cards-podcasts");

class CardP {
    constructor(i, t, s, song) {
        this.imagen = i;
        this.titulo = t;
        this.stitulo = s;
        this.song = song;
    }
    yImagen() {
        let source = this.imagen;

        return source
    }
    yTitulo() {
        let value = this.titulo;

        return value
    }

    ySub() {
        let subvalue = this.stitulo;

        return subvalue
    }
    ySong() {
        let srcc = this.song;

        return srcc
    }
}

var coleccionP = [];
coleccionP.push(new CardP("../adify/resources/images/image.png", "Overthink", "Me and my panas"));
coleccionP.push(new CardP("../adify/resources/images/image.png", "Pieter Brueghel el Viejo", "Autoretrato"));
coleccionP.push(new CardP("../adify/resources/images/image.png", "Ernst Sadler", "Grandes exitos"));
coleccionP.push(new CardP("../adify/resources/images/image.png", "This is Edvard Munch", "A spotify playlist"));
coleccionP.push(new CardP("../adify/resources/images/image.png", "This is Der Blaue Reiter"));
coleccionP.push(new CardP("../adify/resources/images/image.png", "Artistin", "Marcella Kirchner"));

for (var y of coleccionP) {

    if (y.titulo === "Overthink") {
        let childDivY = document.createElement('div');
        childDivY.setAttribute("class", "card-podcast");
        childDivY.setAttribute("id", "ichi");
        let imgY = document.createElement('img');
        imgY.src = y.yImagen();
        fatherDivPodcast.appendChild(childDivY);
        childDivY.appendChild(imgY)
        let infoY = document.createElement('div');
        infoY.setAttribute("class", "infoP");
        let h3 = document.createElement('h3');
        h3.textContent = y.yTitulo();
        infoY.appendChild(h3);
        let spanY = document.createElement('span');
        spanY.textContent = y.ySub();
        infoY.appendChild(spanY);
        childDivY.appendChild(infoY);
        let srccc = y.ySong();
        let titulete = y.yTitulo();
        let subtitulete = y.yTitulo();
        let image = y.yImagen();
        childDivY.addEventListener('click', function () {
            song.src = srccc;
            songinfoh3.textContent = titulete;
            songinfospan.textContent = subtitulete;
            songinfoimg.src = image;
            song.play();
        })
        
    } else {
        let childDivY = document.createElement('div');
        childDivY.setAttribute("class", "card-podcast");
        let imgY = document.createElement('img');
        imgY.src = y.yImagen();
        fatherDivPodcast.appendChild(childDivY);
        childDivY.appendChild(imgY)
        let infoY = document.createElement('div');
        infoY.setAttribute("class", "infoP");
        let h3 = document.createElement('h3');
        h3.textContent = y.yTitulo();
        infoY.appendChild(h3);
        let spanY = document.createElement('span');
        spanY.textContent = y.ySub();
        infoY.appendChild(spanY);
        childDivY.appendChild(infoY);
        let srccc = y.ySong();
        let titulete = y.yTitulo();
        let subtitulete = y.yTitulo();
        let image = y.yImagen();
        childDivY.addEventListener('click', function () {
            song.src = srccc;
            songinfoh3.textContent = titulete;
            songinfospan.textContent = subtitulete;
            songinfoimg.src = image;
            song.play();
        })
    }
}


let play_button = document.getElementById("song_track_play_button");
let songtrack = document.getElementById("songtrack_range");
let volumetrack = document.getElementById("volume");
let song = document.getElementById("audio");
let pause_button = document.getElementById("song_track_stop_button");

let pause_button_two = document.getElementById("main_list_card_info_bottom_button_pause");
let play_button_two = document.getElementById("main_list_card_info_bottom_button_play")


let playS = () => {

    play_button.style.display = "none";
    pause_button.style.display = "unset";

    play_button_two.style.display = "none";
    pause_button_two.style.display = "unset";

    song.play();

}

let playSs = () => {

    play_button.style.display = "unset";
    pause_button.style.display = "none";

    play_button_two.style.display = "unset";
    pause_button_two.style.display = "none";

    song.pause();

}

songtrack.max = song.duration;

play_button.addEventListener("click", playS);
pause_button.addEventListener("click", playSs);

play_button_two.addEventListener("click", playS);
pause_button_two.addEventListener("click", playSs);

song.addEventListener('timeupdate', function () {
    songtrack.max = song.duration;
    let position = song.currentTime;

    songtrack.value = position;
})

songtrack.addEventListener('change', function () {
    song.currentTime = songtrack.value / 1;

})

volumetrack.addEventListener('change', function () {

    let volumeValue = volumetrack.value / 100
    song.volume = volumeValue;

})


// Bruegel, Stadler Ernst, Edvard Munch, Die Brücke o Der Blaue Reiter.

let ichi = document.getElementById("ichi");

let firstcontainer = document.getElementById("firstcontainer");

let secondcontainer = document.getElementById("secondcontainer");

secondcontainer.style.display = "none";

let verifier = false;

if (ichi) {
    ichi.addEventListener("click", function () {
        firstcontainer.style.display = "none";
        secondcontainer.style.display = "unset";
        play_button.style.display = "none";
        pause_button.style.display = "unset";
    
        play_button_two.style.display = "none";
        pause_button_two.style.display = "unset";
        verifier = true;
    });
}

let backarrow_two = document.getElementById("back_and_forwad_two_back");
let forwadarrow_two = document.getElementById("back_and_forwad_two_forward");

let backarrow = document.getElementById("back_and_forwad_back");
let forwadarrow = document.getElementById("back_and_forwad_forward");

backarrow_two.addEventListener("click", function() {
    firstcontainer.style.display = "unset";
    secondcontainer.style.display = "none";

});

forwardarrow.addEventListener("click", function() {
    firstcontainer.style.display = "unset";
    secondcontainer.style.display = "none";

});


