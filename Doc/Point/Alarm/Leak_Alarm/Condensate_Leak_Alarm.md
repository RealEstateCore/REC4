[Point](../../Point.md) > [Alarm](../Alarm.md) > [Leak_Alarm](Leak_Alarm.md) > [Condensate_Leak_Alarm](#)
# Condensate_Leak_Alarm

**Display name:** Condensate Leak Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Condensate_Leak_Alarm;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
