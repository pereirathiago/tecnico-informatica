  
const map = L.map("mapid").setView([-25.091355121868734, -50.16051757407875], 15);

L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png").addTo(map);
var marker =  L.marker([-25.091355121868734, -50.16051757407875]).addTo(map);
marker.bindPopup("<a target='_blank' href='https://www.google.com.br/maps/@-25.0912212,-50.1606227,19.5z'>Clica aqui<a>").openPopup();
