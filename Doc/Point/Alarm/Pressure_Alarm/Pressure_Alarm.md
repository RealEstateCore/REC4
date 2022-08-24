[Point](../../Point.md) > [Alarm](../Alarm.md) > [Pressure_Alarm](.)
# Pressure_Alarm

**Display name:** Pressure Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Pressure_Alarm;1

---


## Child interfaces
* [High_Head_Pressure_Alarm](High_Head_Pressure_Alarm.md)
* [Low_Suction_Pressure_Alarm](Low_Suction_Pressure_Alarm.md)

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
