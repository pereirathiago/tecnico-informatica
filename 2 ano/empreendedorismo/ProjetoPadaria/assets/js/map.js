  
const map = L.map("mapid").setView([-25.091355121868734, -50.16051757407875], 15);

L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png").addTo(map);
var marker =  L.marker([-25.091355121868734, -50.16051757407875]).addTo(map);
