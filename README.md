# Singleton and Factory Method - Medical Centers 🏥

## Introduction 🏁
This project showcases the implementation of two creational design patterns: Singleton and Factory Method. These patterns were applied within a medical center system that manages patients. The system accommodates two types of patients: external patients and insured patients. One of the main objectives of this system is to maintain a common patient registry accessible to all medical centers. This means that when a patient is registered at one medical center, they are automatically included in the patient registry of all medical centers. To achieve this, the Singleton pattern was implemented.

## Creational design patterns used  📚
1. Singleton Pattern

* Definition: The Singleton pattern ensures that a class has only one instance and pr🏁ovides a global point of access to that instance.
* Purpose: The primary purpose of the Singleton pattern is to control access to shared resources, such as a configuration object or a connection pool, ensuring that only one instance is used throughout the application.

2. Factory Method Pattern

* Definition: The Factory Method pattern defines an interface for creating an object, but allows subclasses to alter the type of objects that will be created.
* Purpose: The Factory Method pattern is used to encapsulate the instantiation of objects, allowing a class to defer instantiation to subclasses. This promotes loose coupling in the code by decoupling the object creation process from the actual implementation.
  
## Development ⚙️
* For the creation of patients and medical centers, the Factory Method design pattern was employed. Two distinct factories, MedicalCenterFactory and PatientFactory, were created to interact with the interfaces IMedicalCenter and IPatient
* To maintain a common registry of registered patients, the Singleton pattern was implemented in the PatientList class, which is utilized in the Hospital class during the registration of new patients.

### Class Diagram <div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/Diagrama%20de%20clases.png" /></div>
### Sequence Diagram <div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/SequenceDiadram.png" /></div>
### Singleton Implementation <div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/Singleton.png" /></div>
### Medical Center Factory <div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/MedicalCenterFactory.png" /></div>
### Patient Factory <div style="text-align:center"><img src="https://github.com/DussanFreire/Hospital/blob/main/PatientFactory.png" /></div>
