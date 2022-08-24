[Point](../../Point.md) > [Alarm](../Alarm.md) > [Water_Alarm](.)
# Water_Alarm

**Display name:** Water Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Alarm;1

---


## Child interfaces
* [Deionized_Water_Alarm](Deionized_Water_Alarm.md)
* [No_Water_Alarm](No_Water_Alarm.md)
* [Water_Loss_Alarm](Water_Loss_Alarm.md)
* [Water_Temperature_Alarm](Water_Temperature_Alarm/Water_Temperature_Alarm.md)
* [Water_Level_Alarm](Water_Level_Alarm/Water_Level_Alarm.md)

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
