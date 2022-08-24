[Point](../../Point.md) > [Alarm](../Alarm.md) > [Humidity_Alarm](.)
# Humidity_Alarm

**Display name:** Humidity Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Alarm;1

---


## Child interfaces
* [High_Humidity_Alarm](High_Humidity_Alarm.md)
* [Low_Humidity_Alarm](Low_Humidity_Alarm.md)

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
