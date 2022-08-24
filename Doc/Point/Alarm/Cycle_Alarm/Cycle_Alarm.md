[Point](../../Point.md) > [Alarm](../Alarm.md) > [Cycle_Alarm](.)
# Cycle_Alarm

**Display name:** Cycle Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Cycle_Alarm;1

---


## Child interfaces
* [Short_Cycle_Alarm](Short_Cycle_Alarm.md)

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
