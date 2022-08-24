[Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Water_Alarm](../Water_Alarm.md) > [Water_Level_Alarm](#)
# Water_Level_Alarm

**Display name:** Water Level Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Level_Alarm;1

---


## Child interfaces
* [Collection_Basin_Water_Level_Alarm](Collection_Basin_Water_Level_Alarm.md)
* [Max_Water_Level_Alarm](Max_Water_Level_Alarm.md)
* [Min_Water_Level_Alarm](Min_Water_Level_Alarm.md)

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
