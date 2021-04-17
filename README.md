# Centros Medicos 🏥

### Introduccion:
En el siguiente trabajo se muestra la implementación de dos patrones creacionales, Singleton y FactoryMethod, estos dos patrones fueron aplicados en un sistema de centros médicos los cuates tienen pacientes. Existen dos tipos de pacientes, los pacientes externos y los pacientes asegurados. Otro objetivo de este sistema es tener una lista común de pacientes para todos los centros médicos, es decir, que si un centro médico registra a un paciente este paciente estaría dentro del registro de pacientes de todos los centros médicos, para eso se implementó un singleton.
### Desarrollo: 
* Para la creación de pacientes y centros médicos, se vio por conveniente utilizar el patrón de diseño FactoryMethod, donde se crearon dos fábricas distintas, MedicalCenterFactory y PatientFactory, las cuales interactuaban con las interfaces, IMedicalCenter e IPatient.
* Para tener una lista común de pacientes registrados, se aplicó el patrón creacional Singleton el cual se implementa en la clase "PatientList" la cual se utiliza en la clase "Hospital" al momento de registrar un nuevo paciente

### Diagrama de clases:<div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/Diagrama%20de%20clases.png" /></div>
### Diagrama de Secuencia:<div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/SequenceDiadram.png" /></div>
### Singleton:<div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/Singleton.png" /></div>
### Medical center Factory<div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/MedicalCenterFactory.png" /></div>
### Patient Factory<div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/PatientFactory.png" /></div>
