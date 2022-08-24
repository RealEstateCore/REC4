[Point](../../Point.md) > [Alarm](../Alarm.md) > [Temperature_Alarm](.)
# Temperature_Alarm

**Display name:** Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Alarm;1

---


## Child interfaces
* [Air_Temperature_Alarm](Air_Temperature_Alarm/Air_Temperature_Alarm.md)
* [High_Temperature_Alarm](High_Temperature_Alarm/High_Temperature_Alarm.md)
* [Low_Temperature_Alarm](Low_Temperature_Alarm/Low_Temperature_Alarm.md)
* [Water_Temperature_Alarm](../Water_Alarm/Water_Temperature_Alarm/Water_Temperature_Alarm.md)

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
