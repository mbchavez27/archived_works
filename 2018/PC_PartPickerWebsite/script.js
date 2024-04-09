	var pesos;
var sign;
sign = "$";
pesos = 52.04
var m1,m2,m3,m4,m5;
	m1 = 250;
	m2 = 210;
	m3 = 165;
	m4 = 111;
	m5 = 133;
var gp,gp2,gp3,gp4,gp5;
gp = 1385;
gp2 = 689;
gp3 = 950;
gp4 = 490;	
gp5 = 350;
var cp1,cp2,cp3,cp4,cp5;
cp=540;
cp2=310;
cp3=370;
cp4=195;
cp5=95;
var ps, ps2, ps3, ps4, ps5;
ps = 60;
ps23 = 79;
ps3 = 191;
ps4 = 130;
ps5 = 260;	
var hdd, hdd2,hdd3,hdd4,hdd5;
hdd = 36;
hdd2 = 110;
hdd3 = 54;
hdd4 = 20;
hdd5 = 73;
var r,r2,r3,r4,r5;
r = 105;
r2 = 440;
r3 = 233;
r4 = 90;
r5 = 50;
var c, c2,c3,c4,c5;
c = 120;
c2 = 269;
c3 = 496;
c4 = 183;
c5 = 65;

function givefunction(){
	var part = document.getElementById("pcval").value;
	var sure;
	var res1 = document.getElementById("presult1");
	
	switch(part){
		case "Computers":
		alert("That is the default value! Please pick a PC PART!");
		break;
		

		case "Asus":
	    sure = confirm("Do you really want to know about ASUS?");
	    if (sure == true) {
	        res1.innerHTML = "ASUS is a multinational company known for the world’s best motherboards, personal computers (PCs), monitors, graphics cards, routers and other high-quality technology solutions. With a global workforce that includes more than 5,000 R&D professionals, ASUS leads the industry through cutting-edge innovation and design. Inspired by our In Search of Incredible brand spirit, ASUS won 4,511 international awards in 2017, ranked 26th in Forbes’ Global 2000 Top Regarded Companies, and named among the World’s Most Admired Companies by Fortune.";
	    }
	    else {
	        alert("Well then if you want to try again pls do!");
	    }
		break;

		case "EVGA":
	    sure = confirm("Do you really want to know about EVGA?");
		if(sure == true){
			res1.innerHTML = "EVGA is one of the top NVIDIA authorized partners in channel sales throughout North America. Based on the philosophy of intelligent innovation, market knowledge, and the real time operation, EVGA continues to identify the need in the market place and providing the solution to that need. By offering product differentiation, 24/7 tech service, a 90 day Step-Up program, and other customer focused programs, EVGA is a clear leader in all categories: etail, retail, distribution, and system builders. With headquarters in Brea, CA, EVGA's global coverage includes EVGA GmbH in Munich, EVGA LATAM in Miami, and EVGA Hong Kong.";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;

		case "MSI":
	    sure = confirm("Do you really want to know about MSI?");
		if(sure == true){
			res1.innerHTML = "Micro-Star International Co., Ltd is a Taiwanese multinational information technology corporation headquartered in New Taipei City, Taiwan. It designs, develops and provides computer hardware, related products and services, including laptops, desktops, motherboards, graphics cards, All-in-One PCs, servers, industrial computers, PC peripherals, car infotainment products, etc.";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		case "MotherBoard":
	    sure = confirm("Do you really want to know the function of a MotherBoard?");
		if(sure == true){
			res1.innerHTML = "A motherboard is one of the most essential parts of a computer system. It holds together many of the crucial components of a computer, including the central processing unit (CPU), memory and connectors for input and output devices. The base of a motherboard consists of a very firm sheet of non-conductive material, typically some sort of rigid plastic. Thin layers of copper or aluminum foil, referred to as traces, are printed onto this sheet. These traces are very narrow and form the circuits between the various components. In addition to circuits, a motherboard contains a number of sockets and slots to connect the other components.";
			document.getElementById("giver2").style.visibility = "visible";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		
		case "GPU":
		sure = confirm("Do you really want to know the function of a GPU");
		if(sure == true){
			res1.innerHTML = "A graphics processing unit (GPU) is a specialized electronic circuit designed to rapidly manipulate and alter memory to accelerate the creation of images in a frame buffer intended for output to a display device. GPUs are used in embedded systems, mobile phones, personal computers, workstations, and game consoles. Modern GPUs are very efficient at manipulating computer graphics and image processing. Their highly parallel structure makes them more efficient than general-purpose CPUs for algorithms that process large blocks of data in parallel. In a personal computer, a GPU can be present on a video card or embedded on the motherboard. In certain CPUs, they are embedded on the CPU die.";
			document.getElementById("giver2").style.visibility = "visible";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		
		case "CPU":
		sure = confirm("Do you really want to know the function of a CPU");
		if(sure == true){
			res1.innerHTML = "The central processing unit (CPU) is the unit which performs most of the processing inside a computer. To control instructions and data flow to and from other parts of the computer, the CPU relies heavily on a chipset, which is a group of microchips located on the motherboard.";
			document.getElementById("giver2").style.visibility = "visible";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		
		case "Power Supply":
		sure = confirm("Do you really want to know the function of a Power Supply");
		if(sure == true){
			res1.innerHTML = "A power supply is an electrical device that supplies electric power to an electrical load. The primary function of a power supply is to convert electric current from a source to the correct voltage, current, and frequency to power the load. As a result, power supplies are sometimes referred to as electric power converters. Some power supplies are separate standalone pieces of equipment, while others are built into the load appliances that they power. Examples of the latter include power supplies found in desktop computers and consumer electronics devices. Other functions that power supplies may perform include limiting the current drawn by the load to safe levels, shutting off the current in the event of an electrical fault, power conditioning to prevent electronic noise or voltage surges on the input from reaching the load, power-factor correction, and storing energy so it can continue to power the load in the event of a temporary interruption in the source power (uninterruptible power supply).";
			document.getElementById("giver2").style.visibility = "visible";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		
		case "Hard Drive":
		sure = confirm("Do you really want to know the function of a Hard Drive");
		if(sure == true){
			res1.innerHTML = "A hard disk drive (sometimes abbreviated as hard drive, HD, or HDD) is a non-volatile memory hardware device that permanently stores and retrieves data on a computer. A hard drive is a secondary storage device that consists of one or more platters to which data is written using a magnetic head, all inside of an air-sealed casing. Internal hard disks reside in a drive bay, connect to the motherboard using an ATA, SCSI, or SATA cable, and are powered by a connection to the PSU (power supply unit).";
			document.getElementById("giver2").style.visibility = "visible";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		
		case "Ram":
		sure = confirm("Do you really want to know the function of Ram?");
		if(sure == true){
			res1.innerHTML = "RAM (pronounced ramm) is an acronym for random access memory, a type of computer memory that can be accessed randomly; that is, any byte of memory can be accessed without touching the preceding bytes. RAM is found in servers, PCs, tablets, smartphones and other devices, such as printers.";
			document.getElementById("giver2").style.visibility = "visible";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		case "Case":
		sure = confirm("Do you really want to know the function of a Case?");
		if(sure == true){
			res1.innerHTML = "A computer case, also known as a computer chassis, tower, system unit, CPU (when referring to the case as a whole rather than the processor), or cabinet, is the enclosure that contains most of the components of a computer (usually excluding the display, keyboard, and mouse).";
			document.getElementById("giver2").style.visibility = "visible";
		}
		else {
		    alert("Well then if you want to try again pls do!");
		}
		break;
		default:
		alert("There is no such thing as " + part + "!");
		alert("If there is such thing as " + part + " then please type it the way the list is!");
		break;
	}
}


function giveexample(){
	var part = document.getElementById("pcval").value;
	var sure;
	var res1 = document.getElementById("presult1");
var mb2,gpu2,cpu2,ps2,hd2,ram2,cs2;

mb2 = "A motherboard is one of the most essential parts of a computer system. It holds together many of the crucial components of a computer, including the central processing unit (CPU), memory and connectors for input and output devices. The base of a motherboard consists of a very firm sheet of non-conductive material, typically some sort of rigid plastic. Thin layers of copper or aluminum foil, referred to as traces, are printed onto this sheet. These traces are very narrow and form the circuits between the various components. In addition to circuits, a motherboard contains a number of sockets and slots to connect the other components.";
gpu2 ="A graphics processing unit (GPU) is a specialized electronic circuit designed to rapidly manipulate and alter memory to accelerate the creation of images in a frame buffer intended for output to a display device. GPUs are used in embedded systems, mobile phones, personal computers, workstations, and game consoles. Modern GPUs are very efficient at manipulating computer graphics and image processing. Their highly parallel structure makes them more efficient than general-purpose CPUs for algorithms that process large blocks of data in parallel. In a personal computer, a GPU can be present on a video card or embedded on the motherboard. In certain CPUs, they are embedded on the CPU die.";
cpu2 = "The central processing unit (CPU) is the unit which performs most of the processing inside a computer. To control instructions and data flow to and from other parts of the computer, the CPU relies heavily on a chipset, which is a group of microchips located on the motherboard.";	
ps2 = "A power supply is an electrical device that supplies electric power to an electrical load. The primary function of a power supply is to convert electric current from a source to the correct voltage, current, and frequency to power the load. As a result, power supplies are sometimes referred to as electric power converters. Some power supplies are separate standalone pieces of equipment, while others are built into the load appliances that they power. Examples of the latter include power supplies found in desktop computers and consumer electronics devices. Other functions that power supplies may perform include limiting the current drawn by the load to safe levels, shutting off the current in the event of an electrical fault, power conditioning to prevent electronic noise or voltage surges on the input from reaching the load, power-factor correction, and storing energy so it can continue to power the load in the event of a temporary interruption in the source power (uninterruptible power supply)."; 
hd2 = "A hard disk drive (sometimes abbreviated as hard drive, HD, or HDD) is a non-volatile memory hardware device that permanently stores and retrieves data on a computer. A hard drive is a secondary storage device that consists of one or more platters to which data is written using a magnetic head, all inside of an air-sealed casing. Internal hard disks reside in a drive bay, connect to the motherboard using an ATA, SCSI, or SATA cable, and are powered by a connection to the PSU (power supply unit).";
ram2 = "RAM (pronounced ramm) is an acronym for random access memory, a type of computer memory that can be accessed randomly; that is, any byte of memory can be accessed without touching the preceding bytes. RAM is found in servers, PCs, tablets, smartphones and other devices, such as printers.";
cs2 = "A computer case, also known as a computer chassis, tower, system unit, CPU (when referring to the case as a whole rather than the processor), or cabinet, is the enclosure that contains most of the components of a computer (usually excluding the display, keyboard, and mouse).";

if(part == "MotherBoard" && res1.innerHTML == mb2){
	sure = confirm("Do you really want to know the Examples of Good MotherBoards?");
	if(sure == true){
	document.getElementById("giver2").style.visibility = "hidden";
	res1.innerHTML = "1.Gigabyte Z390 Aorus Ultra<br>Price: "+sign+ m1 +"<br>" + "2.ASUS ROG Maximus XI Hero Wi-Fi<br>Price: "+sign+m2+"<br>"+"3.Asus ROG Strix Z390-I Gaming<br>Price: "+sign+m3+"<br>"+"4.ASUS TUF H370-Pro Gaming Wi-Fi<br>Price: "+sign+m4+"<br>"+"5.MSI Arsenal Z270 Gaming Plus<br>Price: "+sign+m5+"<br>";
	document.getElementById("giver3").style.visibility = "hidden";
	}
	else {
	    alert("Well then if you want to try again pls do!");
	}
}
else if(part == "GPU" && res1.innerHTML == gpu2){
	sure = confirm("Do you really want to know the Examples of Good GPU?");
	if(sure == true){
	res1.innerHTML = "1.Nvidia GeForce RTX 2080 Ti<br>Price: "+sign+ gp +"<br>" + "2.Nvidia GeForce RTX 2080<br>Price: "+sign+gp2+"<br>"+"3.AMD Radeon VII<br>Price: "+sign+gp3+"<br>"+"4.Nvidia GeForce RTX 2070<br>Price: "+sign+gp4+"<br>"+"5.Nvidia GeForce RTX 2060<br>Price: "+sign+gp5+"<br>";
	document.getElementById("giver2").style.visibility = "hidden";
	document.getElementById("giver3").style.visibility = "hidden";
	}
	else {
	    alert("Well then if you want to try again pls do!");
	}
}
else if(part == "CPU" && res1.innerHTML == cpu2){
	sure = confirm("Do you really want to know the Examples of Good CPU?");
	if(sure == true){
	res1.innerHTML = "1.INTEL CORE I9 9900K<br>Price: "+sign+ cp +"<br>" + "2.INTEL CORE I7 8700K<br>Price: "+sign+cp2+"<br>"+"3.AMD Radeon VII<br>Price: "+sign+cp3+"<br>"+"4.AMD RYZEN 7 1700X<br>Price: "+sign+cp4+"<br>"+"5.AMD RYZEN 3 2200G<br>Price: "+sign+cp5+"<br>";
	document.getElementById("giver2").style.visibility = "hidden";
	document.getElementById("giver3").style.visibility = "hidden";
	}
	else {
	    alert("Well then if you want to try again pls do!");
	}
}
else if(part == "Power Supply" && res1.innerHTML == ps2){
	sure = confirm("Do you really want to know the Examples of Good Power Supply?");
	if(sure == true){
	res1.innerHTML = "1.Bitfenix BF450G<br>Price: "+sign+ ps +"<br>" + "2.Corsair RM550x<br>Price: "+sign+ps23+"<br>"+"3.Seasonic SSR-600TL<br>Price: "+sign+ps3+"<br>"+"4.Seasonic SSR-750PX 1700X<br>Price: "+sign+ps4+"<br>"+"5.Corsair AX1000<br>Price: "+sign+ps5+"<br>";
	document.getElementById("giver2").style.visibility = "hidden";
	document.getElementById("giver3").style.visibility = "hidden";
	}
	else {
	    alert("Well then if you want to try again pls do!");
	}
}
else if(part == "Hard Drive" && res1.innerHTML == hd2){
	sure = confirm("Do you really want to know the Examples of Good Hard Drive?");
	if(sure == true){
	res1.innerHTML = "1.Seagate Firecuda Desktop<br>Price: "+sign+ ps +"<br>" + "2.Seagate IronWolf NAS<br>Price: "+sign+ps23+"<br>"+"3.Seagate FireCuda Mobile<br>Price: "+sign+ps3+"<br>"+"4.WD My Book<br>Price: "+sign+ps4+"<br>"+"5.G-Technology G-Drive<br>Price: "+sign+ps5+"<br>";
	document.getElementById("giver2").style.visibility = "hidden";
	document.getElementById("giver3").style.visibility = "hidden";
	}
	else {
	    alert("Well then if you want to try again pls do!");
	}
}
else if(part == "Ram" && res1.innerHTML == ram2){
	sure = confirm("Do you really want to know the Examples of Good Ram?");
	if(sure == true){
	res1.innerHTML = "1.G.Skill Trident Z RGB 16GB DDR4-2400MHz<br>Price: "+sign+ r +"<br>" + "2.Corsair Dominator Platinum 32GB DDR4-3333MHz<br>Price: "+sign+r2+"<br>"+"3.Ballistix Tactical Tracer RGB 32GB DDR4-2666 MHz<br>Price: "+sign+r3+"<br>"+"4.Skill Ripjaws V 16GB DDR4-2400MHz<br>Price: "+sign+r4+"<br>"+"5.Patriot Viper Elite 8GB DDR4-2400MHz<br>Price: "+sign+r5+"<br>";
	document.getElementById("giver2").style.visibility = "hidden";
	document.getElementById("giver3").style.visibility = "hidden";
	}
	else {
	    alert("Well then if you want to try again pls do!");
	}
}
else if(part == "Case" && res1.innerHTML == cs2){
	sure = confirm("Do you really want to know the Examples of Good Case?");
	if(sure == true){
	res1.innerHTML = "1.Corsair Obsidian 500D SE<br>Price: "+sign+ c +"<br>" + "2.Dark Base Pro 900<br>Price: "+sign+c2+"<br>"+"3.Corsair Obsidian 1000D<br>Price: "+sign+r3+"<br>"+"4.NZXT H700i<br>Price: "+sign+c4+"<br>"+"5.Corsair Carbide 275R<br>Price: "+sign+c5+"<br>";
	document.getElementById("giver2").style.visibility = "hidden";
	document.getElementById("giver3").style.visibility = "hidden";
	}
	else {
	    alert("Well then if you want to try again pls do!");
	}
}
else{
    alert("Did you change the value? Please return it to the part that you wish to know");
}
}

function convertmoney(){
	convert();
}







