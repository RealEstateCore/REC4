[Point](../../../Point.md) > [Status](../../Status.md) > [On_Status](../On_Status.md) > [On_Off_Status](.)
# On_Off_Status

**Display name:** On Off Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:On_Off_Status;1

---


## Child interfaces
* [Fan_On_Off_Status](Fan_On_Off_Status.md)
* [Locally_On_Off_Status](Locally_On_Off_Status.md)
* [Motor_On_Off_Status](Motor_On_Off_Status.md)
* [Pump_On_Off_Status](Pump_On_Off_Status.md)
* [Remotely_On_Off_Status](Remotely_On_Off_Status.md)
* [Standby_Unit_On_Off_Status](Standby_Unit_On_Off_Status/Standby_Unit_On_Off_Status.md)
* [Start_Stop_Status](Start_Stop_Status/Start_Stop_Status.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
