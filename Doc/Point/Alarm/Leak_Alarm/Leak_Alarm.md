[Point](../../Point.md) > [Alarm](../Alarm.md) > [Leak_Alarm](.)
# Leak_Alarm

**Display name:** Leak Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leak_Alarm;1

---


## Child interfaces
* [Condensate_Leak_Alarm](Condensate_Leak_Alarm.md)

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
