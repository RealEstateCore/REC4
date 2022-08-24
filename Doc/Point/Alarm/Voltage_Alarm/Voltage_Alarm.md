[Point](../../Point.md) > [Alarm](../Alarm.md) > [Voltage_Alarm](.)
# Voltage_Alarm

**Display name:** Voltage Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Voltage_Alarm;1

---


## Child interfaces
* [Low_Voltage_Alarm](Low_Voltage_Alarm.md)

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
