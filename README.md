# SCS_2022
# The electrocardiogram (ECG)-human activity recognition (HAR) project

Unity Project for Software Critical Systems

## Goal of the electrocardiogram (ECG)-human activity recognition (HAR) project
The goal of the project is to provide ECG learning software for people from the medical paradigm who intend to learn how to handle electrical activities of cardiac muscle fibers. The system provides users with a choice of different patient data sets. The datasets provided each include a full name, age, gender, and a record of ECG data over specific time periods. After a user selects a dataset, the main features of the software will be accessible. The following features are included: a real-time graphical ECG animation which illustrates the rhythmic cardiac muscle contractions. Numerical analysis and interpretation values corresponding to the graph will be displayed and updated in real time. An alarm function that scans for dangerous conditions of the heart rhythm is provided and categorically divides risk conditions on their level of threat. Additional features with associated database requirements can be taken from the requirements specification and will be implemented in future software development cycles.

## Choice of process model
A suitable process model was searched for the project that would balance out the advantages of lightweight attributes, to give our development team the freedom to continually redesign, but it should also provide sufficient structural specifications to guide the course of developement. In the SCS lectures we learned that a combination of the V-Modell XT and the Agile model is a suitable choice for this endeavour. By considering limited time and scope of the software project we chose to pick and adapt the V-Modell XT to our needs. This process is referred to as ”tailoring” and the adapted model can be viewed in figure 1. The image presents the software development life cycle with decision points, taken from V-Modell XT combined with the Kanban method. This idea was inspired by Sabine Canditt et. al ” Br¨uckenschlag: Das V-Modell XT mit Scrum inside”. The Kanban board is a management tool in which individual tasks are separated in process steps. To increase manageability color-coding methods were used. After a task is completed, it is marked with the ”Definition of Done” attribute. All the decision points were discussed and executed with all project members.

![image](https://github.com/user-attachments/assets/b3267607-f73e-4add-a3f9-1e1645cec4e7)
Figure 1

## COCOMO2
A COCOMO 2 calculation was performed to get an estimate of developement time:
Total Unadjusted Function Points (UFP) = 28
Product Complexity Adjustment (PC) = 0.65 + (0.01· Total complexity adjustment value) = 0.65 + (0.01 · 16) = 0.81
Total Adjusted Function Points (FP) = UFP · PC = 22.68
SLOC = FP · LF = 22.4 · 38 = 861.84
KLOC = SLOC/1000 = 0.8618
Effort Adjustment Factor (EAF) = 0.88 · 0.94 · 0.7 · 1 · 1 ·
0.87 · 0.87 · 0.86 · 1.13 · 1 · 1.1 · 0.95 · 1 · 1.10 · 1 = 0.5627
Effort (E) = 3.0 · (KLOC)1.12 · EAF = 3.0 · (0.8618)1.12 ·
0.5627 = 1.429 PM
Development time(D) = 2.5 ·E0.35 = 2.5 · (1.429)0.35 = 2.83 months


## Project Roles and Milestones
The table in figure 2 presents the distribution of project Roles in the V-Modell XT that have been occupied in addition to the defined milestones in figure 3.
<p align="center">
  <img src="https://github.com/user-attachments/assets/b079ff68-a123-452d-b1ed-fe5378a21391" alt="Figure 2 – Project Roles" width="45%" />
  <img src="https://github.com/user-attachments/assets/dee2ead6-6781-4804-aa78-92329b9a525e" alt="Figure 3 – Milestones" width="45%" />
</p>
<p align="center">
  <b>Figure 2:</b> Distribution of project roles in V-Modell XT &nbsp;&nbsp;&nbsp;
  <strong>Figure 3:</strong> Defined milestones
</p>

## SOFTWARE REQUIREMENTS
A sequence diagram of the project:
![image](https://github.com/user-attachments/assets/e52e6e8e-bbc1-4baa-a0a2-53218b3f792a)
![image](https://github.com/user-attachments/assets/d5048d7f-2bfd-46b6-b8b9-7749f3e026ee)


The use case of the project:
![image](https://github.com/user-attachments/assets/55375bcd-e189-4b15-b93f-2dcbc6a3592d)

The UML Diagram of the project:
![image](https://github.com/user-attachments/assets/9e1dcbde-8b82-407c-97cc-d6e88e925ff8)

A state transition diagram of the project:
![image](https://github.com/user-attachments/assets/b9f77e79-0318-4f3f-8226-3f59b5be8e7e)

Results of the Failure Mode And Effects Analysis (FMEA) model:
![image](https://github.com/user-attachments/assets/cf5ce4b6-83d6-4b5c-9735-e9e2a57cd021)

