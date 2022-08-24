[Point](../../Point.md) > [Sensor](../Sensor.md) > [Adjust_Sensor](Adjust_Sensor.md) > [Temperature_Adjust_Sensor](.)
# Temperature_Adjust_Sensor

**Display name:** Temperature Adjust Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Adjust_Sensor;1

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
