[Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Water_Alarm](../Water_Alarm.md) > [Water_Temperature_Alarm](.)
# Water_Temperature_Alarm

**Display name:** Water Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Temperature_Alarm;1

---


## Child interfaces
* [Entering_Water_Temperature_Alarm](Entering_Water_Temperature_Alarm.md)
* [Leaving_Water_Temperature_Alarm](Leaving_Water_Temperature_Alarm.md)

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
